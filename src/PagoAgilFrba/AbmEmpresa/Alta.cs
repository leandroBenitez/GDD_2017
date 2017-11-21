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
        Form main_menu;

        public Alta(Form menu)
        {
            InitializeComponent();
            main_menu = menu;
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
                 || string.IsNullOrEmpty(comboBox_rubro.Text)
                 || string.IsNullOrEmpty(textBox_dia.Text))
            {
                MessageBox.Show("Complete todos los campos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (!textBox_cuit_in.Text.All(char.IsDigit)
                    || !textBox_cuit_medio.Text.All(char.IsDigit)
                    || !textBox_cuit_fin.Text.All(char.IsDigit))
            {
                MessageBox.Show("CUIT sólo caracteres numéricos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_cuit_in.Text = "";
                textBox_cuit_fin.Text = "";
                textBox_cuit_medio.Text = "";
                return;
            }
            else if(!textBox_dia.Text.All(char.IsDigit))
            {
                MessageBox.Show("Día de cobro sólo números", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_dia.Text = "";
                return;
            }
            else if (int.Parse(textBox_dia.Text) > 28 || int.Parse(textBox_dia.Text) < 1)
            {
                MessageBox.Show("Ingrese un día de cobro entre 1 y 28", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_dia.Text = "";
                return;
            }
            else
            {
                string cuit_formateado = textBox_cuit_in.Text + "-" + textBox_cuit_medio.Text + "-" + textBox_cuit_fin.Text;
                if (ValidaCuit(cuit_formateado))
                {
                    string cadena = "Execute PAGO_AGIL.Alta_Empresa '" + textBox_nombre.Text + "', '";
                    cadena = cadena + textBox_direccion.Text + "', '";
                    cadena = cadena + cuit_formateado + "', '";
                    cadena = cadena + comboBox_rubro.Text + "', '";
                    cadena = cadena + textBox_dia.Text + "' ";

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
                else
                {
                    MessageBox.Show("Ingrese un CUIT válido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox_cuit_in.Text = "";
                    textBox_cuit_fin.Text = "";
                    textBox_cuit_medio.Text = "";
                    return;
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

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            main_menu.Show();
            this.Close();
        }

        public static int CalcularDigitoCuit(string cuit)
        {
            int[] mult = new[] { 5, 4, 3, 2, 7, 6, 5, 4, 3, 2 };
            char[] nums = cuit.ToCharArray();
            int total = 0;
            for (int i = 0; i < mult.Length; i++)
            {
                 total += int.Parse(nums[i].ToString()) * mult[i];
            }
            var resto = total % 11;
            return resto == 0 ? 0 : resto == 1 ? 9 : 11 - resto;
        }

        public static bool ValidaCuit(string cuit)
        {
            if (cuit == null)
            {
                return false;
            }
            //Quito los guiones, el cuit resultante debe tener 11 caracteres.
            cuit = cuit.Replace("-", string.Empty);
            if (cuit.Length != 11)
            {
                return false;
            }
            else
            {
                int calculado = CalcularDigitoCuit(cuit);
                int digito = int.Parse(cuit.Substring(10));
                return calculado == digito;
            }
        }
    }
}
