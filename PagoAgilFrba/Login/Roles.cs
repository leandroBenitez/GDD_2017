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
    public partial class Roles : Form
    {
        string main_usuario;
        string main_fecha;

        public Roles(string usuario, string fecha)
        {
            InitializeComponent();
            main_usuario = usuario;
            main_fecha = fecha;
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
                PagoAgilFrba.Login.Menu menu = new PagoAgilFrba.Login.Menu(main_usuario, rol_elegido, main_fecha);
                this.Hide();
                menu.Show();
            }
        }
    }
}
