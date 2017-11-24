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
    public partial class modificaCliente : Form
    {
        Form ClienteMenu;
        private string mailSeleccionado ;
        public modificaCliente(Form menu)
        {
            mailSeleccionado = "" ;
            InitializeComponent();
            ClienteMenu = menu;
            label10.Visible= true;
        }

        private void botLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void busqueda_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gD2C2017DataSet.Lk_Cliente' Puede moverla o quitarla según sea necesario.
            //this.lk_ClienteTableAdapter.Fill(this.gD2C2017DataSet.Lk_Cliente);

        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {

        }

        private void botonModificar_Click(object sender, EventArgs e)
        {






        }

        private void botLimpiar_Click_1(object sender, EventArgs e)
        {
            label10.Visible = true;
            label12.Visible = true;
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
            comboHabilitado.SelectedItem=null;
            dataGridView1.Rows.Clear();
        }

        private void botonModificar_Click_1(object sender, EventArgs e)
        {

            string bitHabilitado = "null";
            string dni_cadena;
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un elemento a modificar", "Modificar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                dniBuscado.Text = row.Cells[0].Value.ToString();
                mailSeleccionado = row.Cells[5].Value.ToString();
                if (comboHabilitado.SelectedIndex != -1)
                {
                    if (comboHabilitado.Text == "Habilitado")
                    { bitHabilitado = "1"; }
                    else { bitHabilitado = "0"; }
                }
                if (dni.Text == "")
                {
                    dni_cadena = "null";
                }
                else
                {
                    dni_cadena = dni.Text;
                };
                PagoAgilFrba.AbmCliente.aux_modificacion aux = new AbmCliente.aux_modificacion(mailSeleccionado, dniBuscado.Text,
                  dniBuscado.Text, row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString(),
                  row.Cells[4].Value.ToString(), mailSeleccionado, row.Cells[6].Value.ToString(), row.Cells[7].Value.ToString(),
                  row.Cells[8].Value.ToString(), this);
                aux.Show();
                this.botonBuscar_Click_1(sender,e);
                this.Hide();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
            button2.Visible = true;
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

        private void button3_Click(object sender, EventArgs e)
        {
            ClienteMenu.Show();
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                dni.ReadOnly = false;
            }
            else
            {
                dni.ReadOnly = true;
                dni.Text = "";
            };
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                apellido.ReadOnly = false;
            }
            else
            {
                apellido.ReadOnly = true;
                apellido.Text = "";
            };
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                nombre.ReadOnly = false;
            }
            else
            {
                nombre.ReadOnly = true;
                nombre.Text = "";
            };
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                telefono.ReadOnly = false;
            }
            else
            {
                telefono.ReadOnly = true;
                telefono.Text = "";
            };
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                button1.Visible = true;
            }
            else
            {
                button1.Visible = false;
                fechaNac.Text = "";
            };
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                mail.ReadOnly = false;
            }
            else
            {
                mail.ReadOnly = true;
                mail.Text = "";
            };
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                direccion.ReadOnly = false;
            }
            else
            {
                direccion.ReadOnly = true;
                direccion.Text = "";
            };
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                codPostal.ReadOnly = false;
            }
            else
            {
                codPostal.ReadOnly = true;
                codPostal.Text = "";
            };
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true)
            {
                comboHabilitado.Visible = true;
            }
            else
            {
                comboHabilitado.Visible = false;
                comboHabilitado.SelectedItem = null;
            }
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
    }
}