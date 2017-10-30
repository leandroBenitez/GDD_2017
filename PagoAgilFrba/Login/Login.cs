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
using System.Windows.Forms;


namespace PagoAgilFrba.Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            warning_user.Hide();
            warning_password.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cadena = "Execute PAGO_AGIL.Login '" + textBox_User.Text + "', '" + textBox_Password.Text + "'";

            conexion connection = new conexion();
            SqlCommand command = new SqlCommand();

            command.CommandText = cadena;
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
            //MessageBox.Show(resultado, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //connection.cerrar_conexion(connection);
        }        
    }
}
