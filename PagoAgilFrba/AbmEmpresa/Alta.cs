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

namespace PagoAgilFrba.AbmEmpresa
{
    public partial class Alta : Form
    {
        public Alta()
        {
            InitializeComponent();
            string consulta = "Select Rubro_Descripcion from PAGO_AGIL.Dim_Rubro";
            Entidades.Herramientas.llenarComboBox(comboBox_rubro, consulta);
        }

        private void button_alta_Click(object sender, EventArgs e)
        {
            if (    string.IsNullOrWhiteSpace(textBox_nombre.Text)
                 || string.IsNullOrWhiteSpace(textBox_direccion.Text)
                 || string.IsNullOrWhiteSpace(textBox_cuit_in.Text)
                 || string.IsNullOrWhiteSpace(textBox_cuit_medio.Text)
                 || string.IsNullOrWhiteSpace(textBox_cuit_fin.Text)
                 || string.IsNullOrEmpty(comboBox_rubro.Text))
            {
                MessageBox.Show("Complete todos los campos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (!textBox_cuit_in.Text.All(char.IsDigit)
                    || !textBox_cuit_medio.Text.All(char.IsDigit)
                    || !textBox_cuit_fin.Text.All(char.IsDigit))
            {
                MessageBox.Show("CUIT sólo caracteres numéricos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            { 
            }
        }
    }
}
