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

namespace PagoAgilFrba.RegistroPago
{
    public partial class RegistroPago : Form
    {
        public RegistroPago(string fecha_sistema, string sucursal)
        {
            InitializeComponent();
            textBox_fecha_sistema.Text = fecha_sistema;
            textBox_sucursal.Text = sucursal;
            string consulta_empresas = "Select distinct emp.Empresa_Nombre from PAGO_AGIL.Dim_Empresa as emp";
            Entidades.Herramientas.llenarComboBox(comboBox_empresa, consulta_empresas);
            string consulta_clientes = "Select (cli.Cliente_Nombre + ' ' + cli.Cliente_Apellido) from PAGO_AGIL.Lk_Cliente as cli";
            Entidades.Herramientas.llenarComboBox(comboBox_cliente, consulta_clientes);
        }

        private void button_registro_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textBox_fecha_venc.Text) || string.IsNullOrWhiteSpace(textBox_importe.Text)  
                || string.IsNullOrWhiteSpace(textBox_nro_fact.Text) || string.IsNullOrEmpty(comboBox_cliente.Text) 
                || string.IsNullOrEmpty(comboBox_empresa.Text))
            {
                MessageBox.Show("Complete todos los campos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
