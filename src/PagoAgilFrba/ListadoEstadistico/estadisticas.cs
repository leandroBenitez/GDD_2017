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

namespace PagoAgilFrba.ListadoEstadistico
{
    public partial class estadisticas : Form
    {
        Form main_menu;

        public estadisticas(Form menu)
        {
            InitializeComponent();
            main_menu = menu;
            combo_trime.Items.Add("Primer trimestre");
            combo_trime.Items.Add("Segundo trimestre");
            combo_trime.Items.Add("Tercer trimestre");
            combo_trime.Items.Add("Cuarto trimestre");
           
            combo_listado.Items.Add("Facturas pagadas por empresa");
            combo_listado.Items.Add("Monto rendido por empresa");
            combo_listado.Items.Add("Clientes con mas pagos");
            combo_listado.Items.Add("Facturas pagadas por cliente");

            string consulta = "Select Distinct YEAR(Factura_Fecha_Vencimiento) anio from PAGO_AGIL.Lk_Factura order by anio";
            Entidades.Herramientas.llenarComboBox(combo_anio, consulta);
        }

        private void button_mostrar_Click(object sender, EventArgs e)
        {
            if ((combo_anio.SelectedIndex == -1) || (combo_trime.SelectedIndex == -1) || (combo_listado.SelectedIndex == -1))
            {
                MessageBox.Show("Seleccione todos los campos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                string consulta;

                if (combo_listado.SelectedIndex == 0)
                {
                    consulta = "Select TOP 5 * from PAGO_AGIL.Vw_FactPagadas";
                    dataGridView.Columns[0].HeaderText = "Empresa";
                    dataGridView.Columns[1].HeaderText = "Rubro";
                    dataGridView.Columns[2].HeaderText = "CUIT";
                    dataGridView.Columns[3].HeaderText = "Porcentage";
                }
                else if (combo_listado.SelectedIndex == 1)
                {
                    consulta = "Select TOP 5 * from PAGO_AGIL.Vw_MayoresRendidos";
                    dataGridView.Columns[0].HeaderText = "Empresa";
                    dataGridView.Columns[1].HeaderText = "Rubro";
                    dataGridView.Columns[2].HeaderText = "CUIT";
                    dataGridView.Columns[3].HeaderText = "Monto rendido";
                }
                else if (combo_listado.SelectedIndex == 2)
                {
                    consulta = "Select TOP 5 * from PAGO_AGIL.Vw_MayoresPagados";
                    dataGridView.Columns[0].HeaderText = "Cliente";
                    dataGridView.Columns[1].HeaderText = "DNI";
                    dataGridView.Columns[2].HeaderText = "Fec Nac";
                    dataGridView.Columns[3].HeaderText = "Pagos";
                }
                else
                {
                    consulta = "Select TOP 5 * from PAGO_AGIL.Vw_MayoresPagadosPorcen";
                    dataGridView.Columns[0].HeaderText = "Cliente";
                    dataGridView.Columns[1].HeaderText = "DNI";
                    dataGridView.Columns[2].HeaderText = "Fec Nac";
                    dataGridView.Columns[3].HeaderText = "Porcentage";
                }

                consulta = consulta + " where anio = " + combo_anio.Text + " and Trimestre = " + combo_trime.SelectedIndex + " + 1";
                consulta = consulta + " order by 4 desc";

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
        }

        private void cargar_datos(SqlDataReader reader)
        {
            dataGridView.Rows.Clear();

            List<DataGridViewRow> filas = new List<DataGridViewRow>();
            Object[] columnas = new Object[4];

            while (reader.Read())
            {
                columnas[0] = reader[0].ToString();
                columnas[1] = reader[1].ToString();
                columnas[2] = reader[2].ToString();
                columnas[3] = reader[3].ToString();

                filas.Add(new DataGridViewRow());
                filas[filas.Count - 1].CreateCells(dataGridView, columnas);
            }

            dataGridView.Rows.AddRange(filas.ToArray());
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            main_menu.Show();
            this.Hide();
        }
    }
}
