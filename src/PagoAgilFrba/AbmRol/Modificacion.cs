﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using PagoAgilFrba.Entidades;

namespace PagoAgilFrba.AbmRol
{
    public partial class Modificacion : Form
    {
        Form main_menu;
        int main_idRol;

        public Modificacion(int id_rol, string nombre_rol, bool habilitado, Form menu)
        {
            InitializeComponent();
            main_menu = menu;
            main_idRol = id_rol;
            textBox_nombre.Text = nombre_rol;
            checkBox_hab.Checked = habilitado;
            llenar_dataViewGrid(id_rol);
        }
        private void llenar_dataViewGrid(int id_rol)
        {
            string consulta = "select distinct fun.Funcionalidad_Id , fun.Funcionalidad_Desc , case when count(rf.Rol_Id) = 0 then '0' else '1' end as Func from PAGO_AGIL.Dim_Funcionalidad as fun ";
            consulta = consulta + " full outer join PAGO_AGIL.Rl_RolxFuncionalidad as rf ";
            consulta = consulta + " on rf.Funcionalidad_Id = fun.Funcionalidad_Id and rf.Rol_Id = '";
            consulta = consulta + main_idRol + "' where Funcionalidad_Desc is not null group by rf.Rol_Id, fun.Funcionalidad_Id, fun.Funcionalidad_Desc";
	
            conexion connection = new conexion();
            SqlCommand command = new SqlCommand();

            command.CommandText = consulta;
            command.CommandType = CommandType.Text;
            command.Connection = connection.abrir_conexion();

            try
            {
                SqlDataReader reader = command.ExecuteReader();
                cargar_funcionalidades(reader);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cargar_funcionalidades(SqlDataReader datos)
        {
            dataGridView_funcionalidades.Rows.Clear();

            List<DataGridViewRow> filas = new List<DataGridViewRow>();
            Object[] columnas = new Object[3];
            int i = 0;
            while (datos.Read())
            {
                columnas[0] = datos[0].ToString();
                columnas[1] = datos[1].ToString();
		
                if (datos[2].ToString() == "1")
                    columnas[2] = true;
                else
                    columnas[2] = false;

                filas.Add(new DataGridViewRow());
                filas[filas.Count - 1].CreateCells(dataGridView_funcionalidades, columnas);
            }

            dataGridView_funcionalidades.Rows.AddRange(filas.ToArray());
        }

        private void button_mod_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView_funcionalidades.Rows)
            {
                string auxiliar;
                //DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[2];
                    
                object value = row.Cells[2].Value;
                if (value != null && (Boolean)value)
                {
                    auxiliar = "1";
                }
                else
                {
                    auxiliar = "0";
                }

                string consulta = "Execute PAGO_AGIL.Rol_Funcionalidad_Modif '" + row.Cells[0].Value.ToString() + "', '" + main_idRol.ToString() + "', '" + auxiliar + "'";
                try
                {
                    conexion connection = new conexion();
                    SqlCommand command = new SqlCommand();

                    command.CommandType = CommandType.Text;
                    command.Connection = connection.abrir_conexion();
                    command.CommandText = consulta;
                    SqlDataReader reader = command.ExecuteReader();
                }
                catch (Exception ex)
                {
                     MessageBox.Show("Error: " + ex.Message);
                     return;
                }
               }

            string auxiliar2;

            if (checkBox_hab.Checked)
            {
                    auxiliar2 = "1";
            }
            else
            {
                    auxiliar2 = "0";
            }

            string consulta2 = "Execute PAGO_AGIL.Mod_Rol '" + main_idRol.ToString() + "', '" + textBox_nombre.Text + "', '" + auxiliar2 + "'";

            try
            {
                conexion connection = new conexion();
                SqlCommand command = new SqlCommand();

                command.CommandType = CommandType.Text;
                command.Connection = connection.abrir_conexion();
                command.CommandText = consulta2;
                SqlDataReader reader = command.ExecuteReader();
                MessageBox.Show("Rol modificado con éxito ", "Rol", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return;
            }
        }

        private void button_atras_Click(object sender, EventArgs e)
        {
            main_menu.Show();
            this.Close();
        }
    }
}
