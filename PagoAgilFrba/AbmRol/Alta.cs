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
    public partial class Alta : Form
    {
        public Alta()
        {
            InitializeComponent();
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

    }
}
