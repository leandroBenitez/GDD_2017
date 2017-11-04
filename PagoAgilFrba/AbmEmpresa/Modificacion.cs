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
    public partial class Modificacion : Form
    {
        private string[] tokens;
        private int id_emp;
        private string cuit_formateado;

        public Modificacion(int idEmp, string nombre, string cuit, string direccion, string rubro, bool habilitado)
        {
            InitializeComponent();
            textBox_nombre.Text = nombre;
            textBox_direccion.Text = direccion;
            tokens = cuit.Split('-');
            textBox_cuit_in.Text = tokens[0];
            textBox_cuit_medio.Text = tokens[1];
            textBox_cuit_fin.Text = tokens[2];
            checkBox_habilitada.Checked = habilitado;
            id_emp = idEmp;
            string consulta = "Select Rubro_Descripcion from PAGO_AGIL.Dim_Rubro";
            Entidades.Herramientas.llenarComboBox(comboBox_rubro, consulta);
            comboBox_rubro.Text = rubro;
        }

        private void button_modificacion_Click(object sender, EventArgs e)
        {
            if (   string.IsNullOrWhiteSpace(textBox_nombre.Text)
                || string.IsNullOrWhiteSpace(textBox_direccion.Text)
                || string.IsNullOrWhiteSpace(textBox_cuit_in.Text)
                || string.IsNullOrWhiteSpace(textBox_cuit_medio.Text)
                || string.IsNullOrWhiteSpace(textBox_cuit_fin.Text)
                || string.IsNullOrEmpty(comboBox_rubro.Text))
            {
                MessageBox.Show("Complete todos los campos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (   !textBox_cuit_in.Text.All(char.IsDigit)
                     || !textBox_cuit_medio.Text.All(char.IsDigit)
                     || !textBox_cuit_fin.Text.All(char.IsDigit))
            {
                MessageBox.Show("CUIT sólo caracteres numéricos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string hab;
                if (checkBox_habilitada.Checked)
                    hab = "1";
                else
                    hab = "0";
                cuit_formateado = textBox_cuit_in + "-" + textBox_cuit_medio + "-" + textBox_cuit_fin;
                string cadena = "Execute PAGO_AGIL.Modificar_Empresa '" + id_emp.ToString() + "', '";
                cadena = cadena + textBox_nombre.Text + "', '";
                cadena = cadena + textBox_direccion.Text + "', '";
                cadena = cadena + cuit_formateado + "', '";
                cadena = cadena + comboBox_rubro.Text + "', '";
                cadena = cadena + hab + "'";

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
                MessageBox.Show("Empresa modificada con éxito", "Empresa modificada", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("CUIT duplicado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_cuit_in.Text = "";
                textBox_cuit_fin.Text = "";
                textBox_cuit_medio.Text = "";
            }
        }
    }
}
