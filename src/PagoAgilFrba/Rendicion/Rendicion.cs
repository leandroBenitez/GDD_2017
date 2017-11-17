using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using PagoAgilFrba.Entidades;

namespace PagoAgilFrba.Rendicion
{
    public partial class Rendicion : Form
    {
        string main_usuario;
        string main_fecha;
        Form main_menu;

        public Rendicion(string usuario, string fecha, Form menu)
        {
            InitializeComponent();
            main_usuario = usuario;
            main_fecha = fecha;
            main_menu = menu;
            combo_rendido.Items.Add("Rendidas");
            combo_rendido.Items.Add("Sin Rendir");
            for (int i = 0; i < 100; i++) { comboBox_comision.Items.Add(i + 1); }
            string consulta = "Select Distinct Periodo from PAGO_AGIL.Vw_Rendidos";
            Entidades.Herramientas.llenarComboBox(comboBox_periodo, consulta);
        }

        private void button_buscar_Click(object sender, EventArgs e)
        {
            click();
        }

        private void click()
        {
            string consulta = "Select * from PAGO_AGIL.Vw_Rendidos where 1 = 1 ";

            if (!string.IsNullOrWhiteSpace(textBox_nombre.Text))
            {
                consulta = consulta + "and Empresa_Nombre LIKE '%" + textBox_nombre.Text + "%' ";
            }
            if (comboBox_periodo.SelectedIndex != -1)
            {
                consulta = consulta + "and Periodo = '%" + comboBox_periodo.Text + "%' ";
            }
            if (combo_rendido.SelectedIndex == 0)
            {
                consulta = consulta + "and Rendida = 'Rendida' ";
            }
            if (combo_rendido.SelectedIndex == 1)
            {
                consulta = consulta + "and Rendida = 'Sin rendir' ";
            }

            consulta = consulta + "order by Empresa_Id, Periodo, Rendida";

            conexion connection = new conexion();
            SqlCommand command = new SqlCommand();

            command.CommandText = consulta;
            command.CommandType = CommandType.Text;
            command.Connection = connection.abrir_conexion();

            try
            {
                SqlDataReader reader = command.ExecuteReader();
                cargar_datos(reader);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cargar_datos(SqlDataReader datos)
        {
            dataGridView.Rows.Clear();

            List<DataGridViewRow> filas = new List<DataGridViewRow>();
            Object[] columnas = new Object[8];

            while (datos.Read())
            {
                columnas[0] = datos["Empresa_Id"].ToString();
                columnas[1] = datos["Empresa_Nombre"].ToString();
                columnas[2] = datos["Empresa_Dia_Rendicion"].ToString();
                columnas[3] = datos["Periodo"].ToString();
                columnas[4] = datos["Cant_Facturas"].ToString();
                columnas[5] = datos["Comision"].ToString();
                columnas[6] = datos["Total"].ToString();
                columnas[7] = datos["Rendida"].ToString();

                filas.Add(new DataGridViewRow());
                filas[filas.Count - 1].CreateCells(dataGridView, columnas);
            }

            dataGridView.Rows.AddRange(filas.ToArray());
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            main_menu.Show();
            this.Close();
        }

        private void button_rendir_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow fila = dataGridView.SelectedRows[0];

                //int cantidad = dataGridView.SelectedRows.Count;

                string id_empresa = fila.Cells["Id_empresa"].Value.ToString();
                string periodo = fila.Cells["Periodo"].Value.ToString();
                string rendido = fila.Cells["Rendida"].Value.ToString();
                string dia_rendicion = fila.Cells["dia_rendic"].Value.ToString();

                if(rendido == "Rendida")
                {
                    MessageBox.Show("La empresa ya ha sido rendida");
                }
                else if(comboBox_comision.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione un porcentaje de comision");
                }
                else if (dia_rendicion != main_fecha.Substring(0,2))
                {
                    MessageBox.Show("Esta empresa solo rinde los dias " + dia_rendicion + " de cada mes");
                }
                else
                {
                    realizar_rendicion(id_empresa, periodo);
                }
            }
            catch
            {
                MessageBox.Show("Debe seleccionar un registro");
            }
        }

        private void realizar_rendicion(string id_empresa, string periodo)
        {
            string consulta = "Execute PAGO_AGIL.Rendir '" + main_fecha + "', '" + main_usuario + "', " + id_empresa + ", '" + periodo + "', " + comboBox_comision.Text;

            conexion connection = new conexion();
            SqlCommand command = new SqlCommand();

            command.CommandText = consulta;
            command.CommandType = CommandType.Text;
            command.Connection = connection.abrir_conexion();

            try
            {
                Object reader = command.ExecuteNonQuery();
                click();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button_limpiar_Click(object sender, EventArgs e)
        {
            textBox_nombre.Text = "";
            comboBox_periodo.SelectedIndex = -1;
            combo_rendido.SelectedIndex = -1;
            comboBox_comision.SelectedIndex = -1;
            dataGridView.Rows.Clear();
        }
    }
}
