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
        Form main_menu;

        public BuscadorRol(Form menu)
        {
            InitializeComponent();
            main_menu = menu;
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
                
                if (datos[2].ToString() == "True")
                    columnas[2] = true;
                else
                    columnas[2] = false;

                filas.Add(new DataGridViewRow());
                filas[filas.Count - 1].CreateCells(dataGridView_resultados, columnas);
            }
            
            dataGridView_resultados.Rows.AddRange(filas.ToArray());

            /*
            string consulta = "select * from PAGO_AGIL.Dim_Rol";
            conexion connection = new conexion();
            SqlCommand command = new SqlCommand();

            command.CommandText = consulta;
            command.CommandType = CommandType.Text;
            command.Connection = connection.abrir_conexion();
            SqlDataReader reader = command.ExecuteReader();

            int i = 0;

            while (reader.Read())
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)dataGridView_resultados.Rows[i].Cells[2];
                if (reader[2].ToString() == "True")
                    chk.Value = chk.TrueValue;
                else
                    chk.Value = chk.FalseValue;
                i++;
            }
            dataGridView_resultados.EndEdit();*/
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
            if (dataGridView_resultados.SelectedRows.Count == 0)
            {
                MessageBox.Show("Elija un rol para modificar", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DataGridViewRow row = this.dataGridView_resultados.SelectedRows[0];
                int idRol = int.Parse(row.Cells[0].Value.ToString());
                string nombre = row.Cells[1].Value.ToString();
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[2];
                bool habilitado;
                if (chk.Value == chk.TrueValue)
                {
                    habilitado = true;
                }
                else
                {
                    habilitado = false;
                }      
                PagoAgilFrba.AbmRol.Modificacion modificacion = new PagoAgilFrba.AbmRol.Modificacion(idRol, nombre, habilitado, this);
                this.Hide();
                modificacion.Show();
            }
        }

        private void button_atras_Click(object sender, EventArgs e)
        {
            main_menu.Show();
            this.Close();
        }
    }
}
