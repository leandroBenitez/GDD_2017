using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.AbmFactura
{
    public partial class Alta : Form
    {
        private string fechactual;
        public float total;
        public int itcount;

        public Alta()
        {
            InitializeComponent();
            fechactual = factfechaalta.Text = ConfigurationManager.AppSettings["DateKey"];
            factvenc.Value = System.DateTime.ParseExact(fechactual, "dd/MM/yyyy HH:mm:ss", null);
            factvenc.MinDate = System.DateTime.ParseExact(fechactual, "dd/MM/yyyy HH:mm:ss", null);
            string empresasc = "Select distinct emp.Empresa_Nombre from PAGO_AGIL.Dim_Empresa as emp";
            Entidades.Herramientas.llenarComboBox(empresas,empresasc);
            string consultaclientes = "Select (cli.Cliente_Nombre + ' ' + cli.Cliente_Apellido) from PAGO_AGIL.Lk_Cliente as cli order by cli.Cliente_Nombre";
            Entidades.Herramientas.llenarComboBox(clientes, consultaclientes);
            facttotal.Text = "0";
            total = 0;
            itcount = 0;
            empresas.Text = "";
            clientes.Text = "";
            factnro.Text = "";

        }

        private void agregar_Click(object sender, EventArgs e)
        {
            if (clientes.Text == "" || empresas.Text == "" || factnro.Text == "")
            {
                MessageBox.Show("no puede haber campos sin completar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);            
            }else
            {
                if (int.Parse(factnro.Text) <= 0)
                {
                    MessageBox.Show("El numero de factura debe ser mayor a cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);            
            
                }
                else if (itcount == 0)
                {
                    MessageBox.Show("La factura debe tene al menos 1 item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {

                }
                
            }

        }

        private void factnro_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            //Controla que el valor ingresado sea un numerico
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }



    }
}
