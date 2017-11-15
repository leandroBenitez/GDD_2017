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
    public partial class Alta : Form
    {
        Form main_menuRol;

        public Alta(Form menuRol)
        {
            InitializeComponent();
            main_menuRol = menuRol;
            llenar_dataViewGrid();
        }

        private void llenar_dataViewGrid()
        {
            string consulta = "select * from PAGO_AGIL.Dim_Funcionalidad";
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

            while (datos.Read())
            {
                columnas[0] = datos[0].ToString();
                columnas[1] = datos[1].ToString();

                filas.Add(new DataGridViewRow());
                filas[filas.Count - 1].CreateCells(dataGridView_funcionalidades, columnas);
            }

            dataGridView_funcionalidades.Rows.AddRange(filas.ToArray());
        }

        private void button_alta_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView_funcionalidades.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[2];
                if (chk.Value == chk.TrueValue)
                {
                    string consulta = "Execute PAGO_AGIL.Rol_Funcionalidad '" + row.Cells[0].Value.ToString() + "'";
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
                    }
                }
            }

            string consulta2 = "Execute PAGO_AGIL.Alta_Rol '" + textBox_nombre.Text + "'";
            try
            {
                conexion connection = new conexion();
                SqlCommand command = new SqlCommand();

                command.CommandType = CommandType.Text;
                command.Connection = connection.abrir_conexion();
                command.CommandText = consulta2;
                SqlDataReader reader = command.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button_atras_Click(object sender, EventArgs e)
        {
            main_menuRol.Show();
            this.Close();
        }
    }
}