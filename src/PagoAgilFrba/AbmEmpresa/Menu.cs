using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.AbmEmpresa
{
    public partial class Menu : Form
    {
        Form main_menu;

        public Menu(Form menu)
        {
            InitializeComponent();
            main_menu = menu;
        }

        private void button_alta_Click(object sender, EventArgs e)
        {
            PagoAgilFrba.AbmEmpresa.Alta alta = new PagoAgilFrba.AbmEmpresa.Alta(this);
            this.Hide();
            alta.Show();
        }

        private void button_mb_Click(object sender, EventArgs e)
        {
            PagoAgilFrba.AbmEmpresa.Buscador_Empresa buscador = new PagoAgilFrba.AbmEmpresa.Buscador_Empresa(this);
            this.Hide();
            buscador.Show();
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            main_menu.Show();
            this.Close();
        }
    }
}
