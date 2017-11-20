using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.Devolucion
{
    public partial class motivo : Form
    {
        public DevolverFactura anterior;
        
        public motivo(DevolverFactura an)
        {
            InitializeComponent();
            anterior = an;

        }

        private void motivos_Click(object sender, EventArgs e)
        {
    
            PagoAgilFrba.Devolucion.auxMotivo aux = new auxMotivo(this,anterior,1);
            aux.Show();
            this.Hide();

        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            PagoAgilFrba.Devolucion.auxMotivo aux = new auxMotivo(this,anterior, 2);
            aux.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            anterior.Show();
            anterior.Enabled = true;
            this.Close();
           
        }
    }
}
