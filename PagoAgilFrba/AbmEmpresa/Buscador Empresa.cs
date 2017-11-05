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

namespace PagoAgilFrba.AbmEmpresa
{
    public partial class Buscador_Empresa : Form
    {
        private int idEmp;
        private string nombre;
        private string cuit;
        private string direccion;
        private string rubro;
        private bool habilitado;

        public Buscador_Empresa()
        {
            InitializeComponent();
            string consulta = "Select Rubro_Descripcion from PAGO_AGIL.Dim_Rubro";
            Entidades.Herramientas.llenarComboBox(combo_rubro, consulta);
        }

        private void button_buscar_Click(object sender, EventArgs e)
        {
            string consulta = "Select * from PAGO_AGIL.Vw_Empresa where 1 = 1 ";

            if (!string.IsNullOrWhiteSpace(textBox_nombre.Text)) 
            {
                consulta = consulta + "and Empresa_Nombre LIKE '%" + textBox_nombre.Text + "%' ";
            }
            if (!string.IsNullOrWhiteSpace(textBox_cuit.Text))
            {
                consulta = consulta + "and Empresa_Cuit LIKE '%" + textBox_cuit.Text + "%' ";
            }
            if (combo_rubro.SelectedIndex != -1)
            {
                consulta = consulta + "and Rubro LIKE '%" + combo_rubro.Text + "%'";
            }

            conexion connection = new conexion();
            SqlCommand command = new SqlCommand();

            command.CommandText = consulta;
            command.CommandType = CommandType.Text;
            command.Connection = connection.abrir_conexion();

            try
            {
                SqlDataReader reader = command.ExecuteReader();
                cargar_datos(reader);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cargar_datos(SqlDataReader datos)
        {
            dataGridView.Rows.Clear();

            List<DataGridViewRow> filas = new List<DataGridViewRow>();
            Object[] columnas = new Object[6];

            while (datos.Read())
            {
                columnas[0] = datos["Empresa_Id"].ToString();
                columnas[1] = datos["Empresa_Nombre"].ToString();
                columnas[2] = datos["Empresa_Cuit"].ToString();
                columnas[3] = datos["Empresa_Direccion"].ToString();
                columnas[4] = datos["Rubro"].ToString();
                columnas[5] = datos["Habilitado"].ToString();

                filas.Add(new DataGridViewRow());
                filas[filas.Count - 1].CreateCells(dataGridView, columnas);
            }

            dataGridView.Rows.AddRange(filas.ToArray());
        }

        private void button_modificar_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Elija una empresa para modificar", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DataGridViewRow row = this.dataGridView.SelectedRows[0];
                idEmp = int.Parse(row.Cells[0].Value.ToString());
                nombre = row.Cells[1].Value.ToString();
                cuit = row.Cells[2].Value.ToString();
                direccion = row.Cells[3].Value.ToString();
                rubro = row.Cells[4].Value.ToString();
                if (row.Cells[5].Value.ToString().Equals("Habilitado"))
                    habilitado = true;
                else
                    habilitado = false;
                PagoAgilFrba.AbmEmpresa.Modificacion modificacion = new PagoAgilFrba.AbmEmpresa.Modificacion(idEmp, nombre, cuit, direccion, rubro, habilitado);
                this.Hide();
                modificacion.Show();

            }
            
        }

        private void button_baja_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Elija una empresa para dar de baja", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DataGridViewRow row = this.dataGridView.SelectedRows[0];
                idEmp = int.Parse(row.Cells[0].Value.ToString());

                string cadena = "Execute PAGO_AGIL.Baja_Empresa '" + idEmp.ToString() + "'";


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

                dataGridView.Rows.Clear();
            }
        }

    }
}
