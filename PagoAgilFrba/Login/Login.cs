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
            string cadena = "Execute PAGO_AGIL.Login '" + textBox_User + "' '" + textBox_Password + "'";

            conexion connection = new conexion();

            SqlCommand command = new SqlCommand(cadena, connection);
            connection.Open();

            try
            {
                SqlDataReader reader = query.ExecuteReader();

                if (reader.HasRows)
                {
                    Console.WriteLine("{0}",reader.GetString(0));
                    MessageBox.Show(reader.GetString(0), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Console.WriteLine("Error al ejecutar consulta.");
                }
                reader.Close();
            }
            catch
            { 
            
            }
            //MessageBox.Show(resultado, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
