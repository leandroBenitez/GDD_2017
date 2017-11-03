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

namespace PagoAgilFrba.AbmSucursal
{
    public partial class Alta : Form
    {

       private bool nameok = true;
       private bool dirok = true;
       private bool cpok = true;

        public Alta()
        {
            InitializeComponent();
        }

        private void Alta_Load(object sender, EventArgs e)
        {
            nombre.Text = "";
            direccion.Text = "";
            cp.Text = "";
        }



        private void button1_Click(object sender, EventArgs e)
        {
            validar_campos();

            if ((nombre.Text == "") || (direccion.Text == "") || (cp.Text == ""))
            {
                MessageBox.Show("no puede haber campos sin completar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(!nameok)
            {
                MessageBox.Show("Nombre hasta 50 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(!dirok)
            {
                MessageBox.Show("Direccion hasta 50 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (!cpok)
            {
                MessageBox.Show("El código postal debe ser distinto de cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           
            }
            else
            {

                string cadena = "exec PAGO_AGIL.agregar_sucursal '" + nombre.Text + "', '" + direccion.Text + "', " + cp.Text;

                conexion connection = new conexion();
                SqlCommand command = new SqlCommand();

                command.CommandText = cadena;
                command.CommandType = CommandType.Text;
                command.Connection = connection.abrir_conexion();

                Object reader = command.ExecuteScalar();
                string elstring = reader.ToString();
                int resultado = int.Parse(elstring);
                if (resultado == -1)
                {
                    MessageBox.Show("Ya existe sucursal con ése código postal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Nueva sucursal registrada", "Alta Sucursal", MessageBoxButtons.OK, MessageBoxIcon.None);
                    nombre.Text = "";
                    direccion.Text = "";
                    cp.Text = "";
                }
                connection.cerrar_conexion(command.Connection);

            }

        }

        private void cp_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            //Controla que el valor ingresado sea un numerico
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void validar_campos()
        {
            nameok = true;
            dirok = true;
            cpok = true;

            if (nombre.TextLength > 50) { nameok = false;}
            if (direccion.TextLength > 50 ){ dirok = false;}
            if (int.Parse(cp.Text) <= 0) { cpok = false; }

        }

      
    }
}
