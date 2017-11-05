using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PagoAgilFrba.Entidades;
using System.Data.SqlClient;

namespace PagoAgilFrba.Login
{
    public partial class Roles : Form
    {
        string main_usuario;
        string main_fecha;
        int main_sucursales;

        public Roles(string usuario, string fecha, int sucursales)
        {
            InitializeComponent();
            main_usuario = usuario;
            main_fecha = fecha;
            main_sucursales = sucursales;
            string consulta = "Select Distinct Rol from PAGO_AGIL.Vw_User_Info where Usuario like '" + usuario + "'";
            Entidades.Herramientas.llenarComboBox(combo_Roles, consulta);
        }

        private void boton_ingresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(combo_Roles.Text) || combo_Roles.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un rol valido", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string rol_elegido = combo_Roles.Text;

                if (main_sucursales == 1)
                {
                    string un_sucursal = dame_sucursal();
                    PagoAgilFrba.Login.Menu menu = new PagoAgilFrba.Login.Menu(main_usuario, rol_elegido, main_fecha, un_sucursal);
                    this.Hide();
                    menu.Show();
                }
                else
                {
                    PagoAgilFrba.Login.Sucursales sucucu = new PagoAgilFrba.Login.Sucursales(main_usuario,main_fecha,rol_elegido);
                    this.Hide();
                    sucucu.Show();
                }
            }
        }

        private string dame_sucursal()
        {
            string cadena = "Select Distinct Sucursal from PAGO_AGIL.Vw_User_Info where Usuario like '" + main_usuario + "'";
            string una_sucursal = "";

            conexion connection = new conexion();
            SqlCommand command = new SqlCommand();

            command.CommandText = cadena;
            command.CommandType = CommandType.Text;
            command.Connection = connection.abrir_conexion();

            try
            {
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                una_sucursal = reader["Sucursal"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return una_sucursal;
        }
    }
}
