using System;
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

        public Modificacion(int id_rol, string nombre_rol, bool habilitado, Form menu)
        {
            InitializeComponent();
            main_menu = menu;
            textBox_nombre.Text = nombre_rol;
            checkBox_hab.Checked = habilitado;
            llenar_dataViewGrid(id_rol);
        }
        private void llenar_dataViewGrid(int id_rol)
        {

            string consulta = "select fun.Funcionalidad_Id, fun.Funcionalidad_Desc, 1 from PAGO_AGIL.Dim_Funcionalidad as fun inner join PAGO_AGIL.Rl_RolxFuncionalidad as rf on rf.Funcionalidad_Id = fun.Funcionalidad_Id inner join PAGO_AGIL.Dim_Rol as rol";
	        consulta = consulta + " on rol.Rol_Id = " + id_rol.ToString() + " ";
            consulta = consulta + "UNION select fun2.Funcionalidad_Id, fun2.Funcionalidad_Desc, 0 from PAGO_AGIL.Dim_Funcionalidad as fun2 inner join PAGO_AGIL.Rl_RolxFuncionalidad as rf2 ";
	        consulta = consulta + "on rf2.Funcionalidad_Id = fun2.Funcionalidad_Id inner join PAGO_AGIL.Dim_Rol as rol2 ";
            consulta = consulta + "on rol2.Rol_Id != " + id_rol.ToString();
	
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
                DataGridViewCheckBoxColumn col = new DataGridViewCheckBoxColumn();
                if (datos[2].ToString().Equals("1"))
                    columnas[2] = col.TrueValue;
                else
                    columnas[2] = col.FalseValue;

                filas.Add(new DataGridViewRow());
                filas[filas.Count - 1].CreateCells(dataGridView_funcionalidades, columnas);
            }

            dataGridView_funcionalidades.Rows.AddRange(filas.ToArray());
        }

        private void button_mod_Click(object sender, EventArgs e)
        {

        }

        private void button_atras_Click(object sender, EventArgs e)
        {
            main_menu.Show();
            this.Close();
        }
    }
}
