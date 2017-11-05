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

namespace PagoAgilFrba.Login
{
    public partial class Sucursales : Form
    {
        string main_usuario;
        string main_fecha;
        string main_rol;

        public Sucursales(string usuario, string fecha, string rol)
        {
            InitializeComponent();
            main_usuario = usuario;
            main_fecha = fecha;
            main_rol = rol;
            string consulta = "Select Distinct Sucursal from PAGO_AGIL.Vw_User_Info where Usuario like '" + usuario + "'";
            Entidades.Herramientas.llenarComboBox(combo_Sucursales, consulta);
        }

        private void boton_ingresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(combo_Sucursales.Text) || combo_Sucursales.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una sucursal valida", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string sucursal_elegida = combo_Sucursales.Text;
                PagoAgilFrba.Login.Menu menu = new PagoAgilFrba.Login.Menu(main_usuario, main_rol, main_fecha, sucursal_elegida);
                this.Hide();
                menu.Show();
            }
        }
    }
}
