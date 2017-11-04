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
    public partial class item : Form
    {
        private Alta anterior;
        public item(Alta n)
        {
            anterior = n;
            InitializeComponent();
            canitem.Text = "";
            precioittotal.Text = "";
        }

        private void additem_Click(object sender, EventArgs e)
        {
            if (canitem.Text == "" || precioittotal.Text == "")
            {
                MessageBox.Show("No puede haber campos nulos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (campos_validos())
            {
                string nuevo = canitem.Text + " - " + precioittotal.Text;
                anterior.string_items.Add(nuevo);
                anterior.itcount++;
                anterior.total += float.Parse(precioittotal.Text,System.Globalization.CultureInfo.InvariantCulture);
                anterior.itemcount.Text = "(" + anterior.itcount + ")";
                anterior.facttotal.Text = anterior.total.ToString();
                MessageBox.Show("Item agregado", "Item", MessageBoxButtons.OK, MessageBoxIcon.None);
                anterior.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("La cantidad y el precio no pueden ser cero", "Item", MessageBoxButtons.OK, MessageBoxIcon.None);
            
            }
        }

        private bool campos_validos()
        {
            bool cantbien =  true;
            bool preciobien = true;
            
            if(int.Parse(canitem.Text) <= 0) cantbien = false;
            if(float.Parse(precioittotal.Text) <= 0) preciobien = false;

            return (cantbien && preciobien);
        }

        private void precioittotal_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            //Controla que el valor ingresado sea un numerico float
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        private void cantitem_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            //Controla que el valor ingresado sea un numerico
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cancelitem_Click(object sender, EventArgs e)
        {
            anterior.Show();
            this.Close();
        }
    }
}
