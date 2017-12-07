using PagoAgilFrba.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.AbmCliente
{
    public partial class aux_modificacion : Form

    {
        private string mailSeleccionado;
        private string dniSeleccionado;
        private string dni_cadena;
        private string bit;
        private string viejo_dni;
        private string viejo_apellido;
        private string viejo_nombre;
        private string viejo_telefono;
        private string viejo_fnac;
        private string viejo_mail;
        private string viejo_dire;
        private string viejo_cp;
        private Form anterior;

        public aux_modificacion(string ms,string db,string dn ,string a,string n,
            string t,string fNac,string m, string d,string c ,string  b, Form ante)
        {
            InitializeComponent();
            mailSeleccionado = ms;
            dniSeleccionado = db;
            viejo_dni = dni.Text = db;
            viejo_apellido = apellido.Text = a;
            viejo_nombre= nombre.Text = n;
            viejo_telefono = telefono.Text= t;
            viejo_fnac = fechaNac.Text = fNac;
            viejo_mail = mail.Text = m;
            viejo_dire = direccion.Text = d;
            viejo_cp = codPostal.Text = c;
            anterior = ante;
            bit = "null";
            if (b == "True")
            {
                
                button5.Enabled = false;
            }
            else
            {
                bit = "1";
                button5.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dni.Text == "" || apellido.Text == "" || nombre.Text == "" || (telefono.Text == "" && viejo_telefono != "")
                || fechaNac.Text == "" || mail.Text == "" || direccion.Text == "" || codPostal.Text == "")
            {
                MessageBox.Show("No puede haber campos vacíos");
            }
            else if (!validarMail())
            {
                MessageBox.Show("El mail debe contener 1 '@'", "Modificacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (viejo_dni != dni.Text)
                {
                    viejo_dni = dni.Text;
                }
                if (viejo_apellido != apellido.Text)
                {
                    viejo_apellido = apellido.Text;
                }
                if (viejo_nombre != nombre.Text)
                {
                    viejo_nombre = nombre.Text;
                }
                if (viejo_fnac != fechaNac.Text)
                {
                    viejo_fnac = fechaNac.Text;
                }
                if (viejo_telefono != telefono.Text)
                {
                    viejo_telefono = telefono.Text;
                }
                if (viejo_mail != mail.Text)
                {
                    viejo_mail = mail.Text;
                }
                else
                {
                    viejo_mail = "";
                }
                if (viejo_dire != direccion.Text)
                {
                    viejo_dire = direccion.Text;
                }
                if (viejo_cp != codPostal.Text)
                {
                    viejo_cp = codPostal.Text;
                }

                string consulta = "Execute PAGO_AGIL.modificaCliente '" + mailSeleccionado + "', " + dniSeleccionado + ", " + viejo_dni + ", '" + viejo_apellido + "', '" +
                        viejo_nombre + "', '" + viejo_telefono + "', '" + viejo_fnac + "', '" + viejo_mail + "', '" + viejo_dire + "', '" +
                        viejo_cp + "', " + bit;
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
                    if (reader.ToString().Contains("exito"))
                    {
                        anterior.Show();
                        this.Close();
                    }
                
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            anterior.Show();

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

        private void button1_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
            button2.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bit = "1";
            button5.Enabled = false;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = false;
            button2.Visible = false;
        }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            fechaNac.Text = monthCalendar1.SelectionStart.Date.ToString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            monthCalendar1.Visible = false;
            button2.Visible = false;
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
