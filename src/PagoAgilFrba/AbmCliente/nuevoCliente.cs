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

            if (!validarMail())
            {
                MessageBox.Show("El e-mail debe contener 1 '@'", "Nuevo Cliente", MessageBoxButtons.OK, MessageBoxIcon.None);
                return;
            }


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
            comboHabilitado.SelectedIndex = -1;
           
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
        private void dni_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            //Controla que el valor ingresado sea un numerico
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void mail_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            //Controla que el valor ingresado sea un numerico
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void nombre_apellido_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            //Controla que el valor ingresado no sea un numerico
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void telefono_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            //Controla que el valor ingresado sea un numerico con/sin guiones
            if (char.IsWhiteSpace(e.KeyChar) || (!char.IsDigit(e.KeyChar) && !(e.KeyChar.ToString() == "-") && !char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private bool validarMail()
        {
            int cant = mail.Text.Count(m => m == '@');
            if (cant == 1) return true;
            else return false;
        }

    }
}
