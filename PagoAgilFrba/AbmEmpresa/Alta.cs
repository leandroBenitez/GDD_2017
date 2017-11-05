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
                string cuit_formateado = textBox_cuit_in.Text + "-" + textBox_cuit_medio.Text + "-" + textBox_cuit_fin.Text;
                string cadena = "Execute PAGO_AGIL.Alta_Empresa '" + textBox_nombre.Text + "', '";
                cadena = cadena + textBox_direccion.Text + "', '";
                cadena = cadena + cuit_formateado + "', '";
                cadena = cadena + comboBox_rubro.Text + "'";

                conexion connection = new conexion();
                SqlCommand command = new SqlCommand();

                command.CommandText = cadena;
                command.CommandType = CommandType.Text;
                command.Connection = connection.abrir_conexion();

                try
                {
                    Object reader = command.ExecuteScalar();
                    string resultado = reader.ToString();
                    tratar_resultado(resultado);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
           
            }
        }

        private void tratar_resultado(string resultado)
        {
            if (resultado.Equals("OK"))
            {
                MessageBox.Show("Empresa dada de alta con éxito", "Alta Empresa", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show(resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_cuit_in.Text = "";
                textBox_cuit_fin.Text = "";
                textBox_cuit_medio.Text = "";
            }
        }
    }
}
