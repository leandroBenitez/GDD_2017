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
        Form ClienteMenu;
        public nuevoCliente(Form menu)
        {
            InitializeComponent();
            ClienteMenu = menu;
        }

        private void botonNuevo_Click(object sender, EventArgs e)
        {



        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void botonNuevo_Click_1(object sender, EventArgs e)
        {
                        if (
            dni.Text != ""
            && apellido.Text != ""
            && nombre.Text != ""
            && telefono.Text != ""
            && mail.Text != ""
            && direccion.Text != ""
            && codPostal.Text != ""
            && fechaNac.Text != ""
            && comboHabilitado.Text != "")
            {
            string consulta;
            string bitHabilitado = "";
            if (comboHabilitado.Text == "Habilitado")
            { bitHabilitado = "1"; }
            else { bitHabilitado = "0"; }

            consulta = "Execute PAGO_AGIL.nuevoCliente " + dni.Text + ", '" + apellido.Text + "', '" +
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
                else { MessageBox.Show("Todos los campos deben estar completos"); };
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

        private void button1_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
            button2.Visible = true;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            fechaNac.Text = monthCalendar1.SelectionStart.Date.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = false;
            button2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClienteMenu.Show();
            this.Close();
        }
    }
}
