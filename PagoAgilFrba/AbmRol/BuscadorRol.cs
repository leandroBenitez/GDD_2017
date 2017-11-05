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
    public partial class BuscadorRol : Form
    {
        public BuscadorRol()
        {
            InitializeComponent();
            llenar_dataViewGrid();
        }

        private void llenar_dataViewGrid()
        {
            string consulta = "select * from PAGO_AGIL.Dim_Rol";
            conexion connection = new conexion();
            SqlCommand command = new SqlCommand();

            command.CommandText = consulta;
            command.CommandType = CommandType.Text;
            command.Connection = connection.abrir_conexion();

            try
            {
                SqlDataReader reader = command.ExecuteReader();
                cargar_roles(reader);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cargar_roles(SqlDataReader datos)
        {
            dataGridView_resultados.Rows.Clear();

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
                filas[filas.Count - 1].CreateCells(dataGridView_resultados, columnas);
            }

            dataGridView_resultados.Rows.AddRange(filas.ToArray());
        }

        private void button_baja_Click(object sender, EventArgs e)
        {
            if (dataGridView_resultados.SelectedRows.Count == 0)
            {
                MessageBox.Show("Elija una rol para dar de baja", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string idRol;
                DataGridViewRow row = this.dataGridView_resultados.SelectedRows[0];
                idRol = row.Cells[0].Value.ToString();

                string cadena = "Execute PAGO_AGIL.Baja_Rol '" + idRol + "'";

                conexion connection = new conexion();
                SqlCommand command = new SqlCommand();

                command.CommandText = cadena;
                command.CommandType = CommandType.Text;
                command.Connection = connection.abrir_conexion();

                try
                {
                    Object reader = command.ExecuteScalar();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

                llenar_dataViewGrid();
            }
        }

        private void button_modificar_Click(object sender, EventArgs e)
        {

        }

    }
}
