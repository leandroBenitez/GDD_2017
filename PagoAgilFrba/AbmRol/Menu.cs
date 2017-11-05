using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.AbmRol
{
    public partial class Menu : Form
    {
        Form main_menu;

        public Menu(Form menu)
        {
            main_menu = menu;
            InitializeComponent();
        }

        private void button_alta_Click(object sender, EventArgs e)
        {
            PagoAgilFrba.AbmRol.Alta alta_rol = new PagoAgilFrba.AbmRol.Alta(this);
            this.Hide();
            alta_rol.Show();
        }

        private void button_busqueda_Click(object sender, EventArgs e)
        {
            PagoAgilFrba.AbmRol.BuscadorRol busca_rol = new PagoAgilFrba.AbmRol.BuscadorRol(this);
            this.Hide();
            busca_rol.Show();
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            main_menu.Show();
            this.Close();
        }
    }
}
