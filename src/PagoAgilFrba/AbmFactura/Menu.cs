using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.AbmFactura
{
    public partial class Menu : Form
    {
        private Form ant;
        public Menu(Form an)
        {
            InitializeComponent();
            ant = an;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PagoAgilFrba.AbmFactura.Modificar a = new PagoAgilFrba.AbmFactura.Modificar(this);
            a.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PagoAgilFrba.AbmFactura.Alta a = new PagoAgilFrba.AbmFactura.Alta(this);
            a.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ant.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PagoAgilFrba.AbmFactura.eliminar a = new PagoAgilFrba.AbmFactura.eliminar(this);
            a.Show();
            this.Hide();

        }
    }
}
