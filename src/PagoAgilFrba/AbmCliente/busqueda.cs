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
    public partial class busqueda : Form
    {
        Form ClienteMenu;
        public busqueda(Form menu)
        {
            InitializeComponent();
            ClienteMenu = menu;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }





        private void botonBuscar_Click(object sender, EventArgs e)
        {

        }

        private void botLimpiar_Click(object sender, EventArgs e)
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

            if (!string.IsNullOrWhiteSpace(telefono.Text))
            {
                consulta = consulta + "and Cliente_Telefono LIKE '%" + telefono.Text + "%' ";
            }

            if (!string.IsNullOrWhiteSpace(mail.Text))
            {
                consulta = consulta + "and Cliente_Mail LIKE '%" + mail.Text + "%' ";
            }

            if (!string.IsNullOrWhiteSpace(direccion.Text))
            {
                consulta = consulta + "and Cliente_Direccion LIKE '%" + direccion.Text + "%' ";
            }

            if (!string.IsNullOrWhiteSpace(codPostal.Text))
            {
                consulta = consulta + "and Cliente_Codigo_Postal LIKE '%" + codPostal.Text + "%' ";
            }

            if (!string.IsNullOrWhiteSpace(fechaNac.Text))
            {
                consulta = consulta + "and Cliente_Fecha_Nac = '" + fechaNac.Text + "' ";
            }


            if (comboHabilitado.SelectedIndex != -1)
            {
                if (comboHabilitado.Text == "Habilitado")
                { bitHabilitado = "1"; }
                else { bitHabilitado = "0"; }
                consulta = consulta + "and Cliente_Habilitado = " + bitHabilitado;
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

        private void botonBuscar_Click_1(object sender, EventArgs e)
        {
            dni.Text = "";
            apellido.Text = "";
            nombre.Text = "";
            telefono.Text = "";
            mail.Text = "";
            direccion.Text = "";
            codPostal.Text = "";
            fechaNac.Text = "";
            comboHabilitado.SelectedItem = null;
            dataGridView1.Rows.Clear();
        }

        private void fechaNac_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            //fechaNac.Text = monthCalendar1.DateSelected.ToString();
            fechaNac.Text = monthCalendar1.SelectionStart.Date.ToString();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
            button2.Visible = true;
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
            //Controla que el valor ingresado sea un numerico
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


    }
}
