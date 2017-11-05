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

namespace PagoAgilFrba.AbmCliente1
{
    public partial class bajaCliente : Form
    {
        public bajaCliente()
        {
            InitializeComponent();
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {

        }

        private void busqueda_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gD2C2017DataSet.Lk_Cliente' Puede moverla o quitarla según sea necesario.
            //this.lk_ClienteTableAdapter.Fill(this.gD2C2017DataSet.Lk_Cliente);

        }

        private void botonDeshabilitar_Click(object sender, EventArgs e)
        {

        }

        private void botonBuscar_Click_1(object sender, EventArgs e)
        {
            string consulta = "Select * from PAGO_AGIL.Lk_Cliente where 1 = 1 ";
            string bitHabilitado = "";
            if (!string.IsNullOrWhiteSpace(dni.Text))
            {
                consulta = consulta + "and Cliente_Dni = " + dni.Text + " ";
            }
            if (!string.IsNullOrWhiteSpace(apellido.Text))
            {
                consulta = consulta + "and Cliente_Apellido LIKE '%" + apellido.Text + "%' ";
            }
            if (!string.IsNullOrWhiteSpace(nombre.Text))
            {
                consulta = consulta + "and Cliente_Nombre LIKE '%" + nombre.Text + "%' ";
            }

            if (!string.IsNullOrWhiteSpace(direccion.Text))
            {
                consulta = consulta + "and Cliente_Direccion LIKE '%" + direccion.Text + "%' ";
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
                connection.cerrar_conexion(command.Connection);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cargar_datos(SqlDataReader datos)
        {
            dataGridView1.Rows.Clear();

            List<DataGridViewRow> filas = new List<DataGridViewRow>();
            Object[] columnas = new Object[9];

            while (datos.Read())
            {
                columnas[0] = datos["Cliente_Dni"].ToString();
                columnas[1] = datos["Cliente_Apellido"].ToString();
                columnas[2] = datos["Cliente_Nombre"].ToString();
                columnas[3] = datos["Cliente_Telefono"].ToString();
                columnas[4] = datos["Cliente_Fecha_Nac"].ToString();
                columnas[5] = datos["Cliente_Mail"].ToString();
                columnas[6] = datos["Cliente_Direccion"].ToString();
                columnas[7] = datos["Cliente_Codigo_Postal"].ToString();
                columnas[8] = datos["Cliente_Habilitado"].ToString();

                filas.Add(new DataGridViewRow());
                filas[filas.Count - 1].CreateCells(dataGridView1, columnas);
            }

            dataGridView1.Rows.AddRange(filas.ToArray());
        }

        private void botonDeshabilitar_Click_1(object sender, EventArgs e)
        {
            if (dni.Text != "")
            {
                string consulta = "Execute PAGO_AGIL.bajaCliente " + dni.Text;
                conexion connection = new conexion();
                SqlCommand command = new SqlCommand();

                command.CommandText = consulta;
                command.CommandType = CommandType.Text;
                command.Connection = connection.abrir_conexion();

                try
                {
                    Object reader = command.ExecuteScalar();
                    string reultado = reader.ToString();
                    reader.ToString();
                    MessageBox.Show(reader.ToString(), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else { MessageBox.Show("El campo DNI no puede estar vacio"); }
        }


    }
}

