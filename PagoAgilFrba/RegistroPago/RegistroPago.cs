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
using System.Data.SqlClient;

namespace PagoAgilFrba.RegistroPago
{
    public partial class RegistroPago : Form
    {
        private int cantidad_fact;
        private float monto_total;

        public RegistroPago(string fecha_sistema, string sucursal)
        {
            InitializeComponent();
            textBox_fecha_sistema.Text = fecha_sistema;
            textBox_sucursal.Text = sucursal;
            label_cant.Text = "0";
            label_total.Text = "0";
            cantidad_fact = 0;
            monto_total = 0;
            string consulta_empresas = "Select distinct emp.Empresa_Nombre from PAGO_AGIL.Dim_Empresa as emp";
            Entidades.Herramientas.llenarComboBox(comboBox_empresa, consulta_empresas);
            string consulta_clientes = "Select (cli.Cliente_Nombre + ' ' + cli.Cliente_Apellido) from PAGO_AGIL.Lk_Cliente as cli";
            Entidades.Herramientas.llenarComboBox(comboBox_cliente, consulta_clientes);
        }

        private void button_registro_Click(object sender, EventArgs e)
        {

        }

        private void button_agregar_Click(object sender, EventArgs e)
        {
            if (    string.IsNullOrWhiteSpace(textBox_fecha_venc.Text) 
                 || string.IsNullOrWhiteSpace(textBox_importe.Text)
                 || string.IsNullOrWhiteSpace(textBox_nro_fact.Text)
                 || string.IsNullOrEmpty(comboBox_empresa.Text) 
                 || string.IsNullOrEmpty(comboBox_cliente.Text)
                 || string.IsNullOrEmpty(comboBox_forma.Text))
            {
                MessageBox.Show("Complete todos los campos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            { 
                comboBox_cliente.Enabled = false;
                comboBox_forma.Enabled = false;
            }

            string cadena = "Execute PAGO_AGIL.Agregar_Pago '" + comboBox_empresa.Text + "', '" + textBox_fecha_sistema.Text + "', '";
            
            conexion connection = new conexion();
            SqlCommand command = new SqlCommand();

            command.CommandText = cadena;
            command.CommandType = CommandType.Text;
            command.Connection = connection.abrir_conexion();

            try
            {
                Object reader = command.ExecuteScalar();
                string resultado = reader.ToString();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            
            cantidad_fact++;
            label_cant.Text = cantidad_fact.ToString();

            monto_total += Int16.Parse(textBox_importe.Text);
            label_total.Text = monto_total.ToString();

            textBox_nro_fact.Text = "";
            comboBox_empresa.SelectedIndex = -1;
            textBox_fecha_venc.Text = "";
            textBox_importe.Text = "";


        }
    }
}
