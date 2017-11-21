using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.AbmCliente1
{
    public partial class mainABMClie : Form
    {
        Form main_menu;
        public mainABMClie(Form menu)
        {

            InitializeComponent();
            main_menu = menu;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbmCliente1.busqueda frm = new AbmCliente1.busqueda(this);
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbmCliente1.nuevoCliente frm = new AbmCliente1.nuevoCliente(this);
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbmCliente1.modificaCliente frm = new AbmCliente1.modificaCliente(this);
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbmCliente1.bajaCliente frm = new AbmCliente1.bajaCliente(this);
            frm.Show();
            this.Hide();
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {

            main_menu.Show();
            this.Close();
        }

        private void mainABMClie_Load(object sender, EventArgs e)
        {

        }
    }
}
