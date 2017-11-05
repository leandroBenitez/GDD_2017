using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using PagoAgilFrba.Entidades;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace PagoAgilFrba.Login
{
    public partial class Login : Form
    {
        string fecha_sistema;
        string rol_defecto;

        public Login()
        {
            InitializeComponent();
            warning_user.Visible = false;
            warning_password.Visible = false;
            fecha_sistema = ConfigurationManager.AppSettings["DateKey"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_User.Text) || string.IsNullOrWhiteSpace(textBox_Password.Text))
            {
                MessageBox.Show("Complete todos los campos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_Password.Text = "";
                warning_user.Visible = false;
                warning_password.Visible = false;
                return;
            }

            string cadena = "Execute PAGO_AGIL.Login '" + textBox_User.Text + "', '" + textBox_Password.Text + "'";

            conexion connection = new conexion();
            SqlCommand command = new SqlCommand();

            command.CommandText = cadena;
            command.CommandType = CommandType.Text;
            command.Connection = connection.abrir_conexion();

            try
            {
                Object reader = command.ExecuteScalar();
                string resultado = reader.ToString();
                tratar_resultado(resultado);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void tratar_resultado(string resultado) 
        {
            warning_user.Visible = false;
            warning_password.Visible = false;

            if (resultado == "Inexistente")
            {
                warning_user.Visible = true;
                textBox_User.Text = "";
                textBox_Password.Text = "";
                textBox_User.Focus();
            }
            else if (resultado == "Inhabilitado")
            {
                MessageBox.Show("El usuario ingresado se encuentra inhabilitado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (resultado == "Invalido")
            {
                warning_password.Visible = true;
                textBox_Password.Text = "";
                textBox_Password.Focus();
            }
            else
            {
                chequear_user();
            }
        }

        private void chequear_user()
        {
            string cadena = "Select Count(Distinct Rol) as Cant_Roles, Count(Distinct Sucursal) as Cant_Suc from PAGO_AGIL.Vw_User_Info where Usuario like '" + textBox_User.Text + "'";

            conexion connection = new conexion();
            SqlCommand command = new SqlCommand();

            command.CommandText = cadena;
            command.CommandType = CommandType.Text;
            command.Connection = connection.abrir_conexion();

            try
            {
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                string cant_roles = reader["Cant_Roles"].ToString();
                string cant_suc = reader["Cant_Suc"].ToString();

                if (Int32.Parse(cant_roles) == 0)
                {
                    MessageBox.Show("El usuario ingresado no tiene roles activos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (Int32.Parse(cant_suc) == 0)
                {
                    MessageBox.Show("El usuario ingresado no tiene sucursales asociadas", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if ( (Int32.Parse(cant_roles) == 1) && (Int32.Parse(cant_suc) == 1) )
                {
                    ingresar_defecto();
                }
                else if (Int32.Parse(cant_roles) > 1)
                {
                    PagoAgilFrba.Login.Roles form_roles = new PagoAgilFrba.Login.Roles(textBox_User.Text, fecha_sistema, int.Parse(cant_suc));
                    this.Hide();
                    form_roles.Show();
                }
                else if (Int32.Parse(cant_suc) > 1)
                {
                    string un_rol = dame_rol();
                    PagoAgilFrba.Login.Sucursales form_suc = new PagoAgilFrba.Login.Sucursales(textBox_User.Text, fecha_sistema, un_rol);
                    this.Hide();
                    form_suc.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ingresar_defecto()
        {
            string cadena = "Select Distinct Rol, Sucursal from PAGO_AGIL.Vw_User_Info where Usuario like '" + textBox_User.Text + "'";

            conexion connection = new conexion();
            SqlCommand command = new SqlCommand();

            command.CommandText = cadena;
            command.CommandType = CommandType.Text;
            command.Connection = connection.abrir_conexion();

            try
            {
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                string un_rol = reader["Rol"].ToString();
                string un_suc = reader["Sucursal"].ToString();

                PagoAgilFrba.Login.Menu form_menu = new PagoAgilFrba.Login.Menu(textBox_User.Text, un_rol, fecha_sistema, un_suc);
                this.Hide();
                form_menu.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private string dame_rol()
        {
            string cadena = "Select Distinct Rol from PAGO_AGIL.Vw_User_Info where Usuario like '" + textBox_User.Text + "'";
            string un_rol = "";

            conexion connection = new conexion();
            SqlCommand command = new SqlCommand();

            command.CommandText = cadena;
            command.CommandType = CommandType.Text;
            command.Connection = connection.abrir_conexion();

            try
            {
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                un_rol = reader["Rol"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return un_rol;
        }
    }
}
