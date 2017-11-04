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
    public partial class nuevoCliente : Form
    {
        public nuevoCliente()
        {
            InitializeComponent();
        }

        private void botonNuevo_Click(object sender, EventArgs e)
        {



        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void botonNuevo_Click_1(object sender, EventArgs e)
        {
            string consulta;
            string bitHabilitado = "";
            if (comboHabilitado.Text == "Habilitado")
            { bitHabilitado = "1"; }
            else { bitHabilitado = "0"; }

            consulta = "Execute nuevoCliente " + dni.Text + ", '" + apellido.Text + "', '" +
            nombre.Text + "', '" + telefono.Text + "', '" + fechaNac.Text + "', '" + mail.Text + "', '" + direccion.Text + "', '" +
            codPostal.Text + "', " + bitHabilitado;
            conexion connection = new conexion();
            SqlCommand command = new SqlCommand();

            command.CommandText = consulta;
            command.CommandType = CommandType.Text;
            command.Connection = connection.abrir_conexion();

            try
            {
                Object reader = command.ExecuteScalar();
                string reultado = reader.ToString();
                //reader.ToString();
                MessageBox.Show(reader.ToString(), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void botonLimpiar_Click_1(object sender, EventArgs e)
        {
            dni.Text = "";
            apellido.Text = "";
            nombre.Text = "";
            telefono.Text = "";
            mail.Text = "";
            direccion.Text = "";
            codPostal.Text = "";
            fechaNac.Text = "";
            comboHabilitado.Text = "";
        }
    }
}
