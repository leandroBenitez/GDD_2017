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
        private string usuario;
        Form main_menu;

        public RegistroPago(string fecha_sistema, string sucursal, Form menu, string user)
        {
            InitializeComponent();
            main_menu = menu;
            textBox_fecha_sistema.Text = fecha_sistema;
            textBox_sucursal.Text = sucursal;
            textBox_user.Text = user;
            usuario = user;
            label_cant.Text = "0";
            label_total.Text = "0";
            cantidad_fact = 0;
            monto_total = 0;
            cargar_clientes("");
            cargar_empresas("");
            string consulta = "Select Distinct FormaPago_Desc from PAGO_AGIL.Dim_FormaPago";
            Entidades.Herramientas.llenarComboBox(comboBox_forma, consulta);        
        }

        public void cargar_clientes(string filtro)
        {
            comboBox_cliente.Items.Clear();
            string consulta = "Select (Cliente_Nombre + ' ' + Cliente_Apellido) from PAGO_AGIL.Lk_Cliente where Cliente_Nombre + ' ' + Cliente_Apellido like '%" + filtro + "%'";
            Entidades.Herramientas.llenarComboBox(comboBox_cliente, consulta);
        }

        public void cargar_empresas(string filtro)
        {
            comboBox_empresa.Items.Clear();
            string consulta = "Select Distinct Empresa_Nombre from PAGO_AGIL.Dim_Empresa where Empresa_Nombre like '%" + filtro + "%'";
            Entidades.Herramientas.llenarComboBox(comboBox_empresa, consulta);
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            ejecutar_limpieza();
            limpiar_base();
            main_menu.Show();
            this.Close();
        }

        private void button_buscar_cliente_Click(object sender, EventArgs e)
        {
            cargar_clientes(textBox_cliente.Text);
            comboBox_cliente.DroppedDown = true;
        }

        private void button_buscar_empresa_Click(object sender, EventArgs e)
        {
            cargar_empresas(textBox_empresa.Text);
            comboBox_empresa.DroppedDown = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ejecutar_carga();
        }

        public void ejecutar_carga()
        {
            string consulta = "Select * from PAGO_AGIL.Vw_Facturas where 1 = 1";

            if (comboBox_cliente.SelectedIndex != -1)
            {
                consulta = consulta + " and Cliente like '" + comboBox_cliente.Text + "'";
            }

            if (comboBox_empresa.SelectedIndex != -1)
            {
                consulta = consulta + " and Empresa like '" + comboBox_empresa.Text + "'";
            }

            consulta = consulta + " and Factura_Pagado = 0";

            conexion connection = new conexion();
            SqlCommand command = new SqlCommand();

            command.CommandText = consulta;
            command.CommandType = CommandType.Text;
            command.Connection = connection.abrir_conexion();

            try
            {
                SqlDataReader reader = command.ExecuteReader();
                cargar_grid_todos(reader);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }        
        }

        public void cargar_grid_todos(SqlDataReader reader)
        {
            dataGridView_total.Rows.Clear();

            List<DataGridViewRow> filas = new List<DataGridViewRow>();
            Object[] columnas = new Object[7];

            while (reader.Read())
            {
                columnas[0] = reader[0].ToString();
                columnas[1] = reader[1].ToString();
                columnas[2] = reader[2].ToString();
                columnas[3] = reader[3].ToString();
                columnas[4] = reader[4].ToString();
                columnas[5] = reader[5].ToString();
                columnas[6] = reader[6].ToString();

                filas.Add(new DataGridViewRow());
                filas[filas.Count - 1].CreateCells(dataGridView_total, columnas);
            }

            dataGridView_total.Rows.AddRange(filas.ToArray());
        }

        private void button_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow fila = dataGridView_total.SelectedRows[0];
                List<DataGridViewRow> filas = new List<DataGridViewRow>();

                string consulta = "Execute PAGO_AGIL.FacturaPaga '" + textBox_fecha_sistema.Text + "', " + fila.Cells[0].Value.ToString();

                conexion connection = new conexion();
                SqlCommand command = new SqlCommand();

                command.CommandText = consulta;
                command.CommandType = CommandType.Text;
                command.Connection = connection.abrir_conexion();

                SqlDataReader reader = command.ExecuteReader();
                reader.Read();

                string resultado = reader[0].ToString(); ;

                if (resultado == "Empresa inhabilitada")
                {
                    MessageBox.Show("La empresa se encuentra inhabilitada");
                }
                else if (resultado == "Factura vencida")
                {
                    MessageBox.Show("La factura se encuentra vencida");
                }
                else if (resultado == "Monto 0")
                {
                    MessageBox.Show("El monto de la factura no es correcto");
                }
                else
                {
                    agregar_item();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe seleccionar una factura");
            }
        }

        public void agregar_item()
        {
            try
            {
                DataGridViewRow fila = dataGridView_total.SelectedRows[0];

                List<DataGridViewRow> filas = new List<DataGridViewRow>();
                Object[] columnas = new Object[7];

                columnas[0] = fila.Cells[0].Value.ToString();
                columnas[1] = fila.Cells[1].Value.ToString();
                columnas[2] = fila.Cells[2].Value.ToString();
                columnas[3] = fila.Cells[3].Value.ToString();
                columnas[4] = fila.Cells[4].Value.ToString();
                columnas[5] = fila.Cells[5].Value.ToString();
                columnas[6] = fila.Cells[6].Value.ToString();

                filas.Add(new DataGridViewRow());
                filas[filas.Count - 1].CreateCells(dataGridView_total, columnas);

                dataGridView_confirmados.Rows.AddRange(filas.ToArray());

                cantidad_fact++;
                monto_total = monto_total + float.Parse(fila.Cells[6].Value.ToString());
                label_cant.Text = cantidad_fact.ToString();
                label_total.Text = monto_total.ToString();

                comboBox_cliente.Enabled = false;

                ejecutar_carga();
            }
            catch
            {
                MessageBox.Show("Debe seleccionar un registro");
            }        
        }

        private void button_limpiar_Click(object sender, EventArgs e)
        {
            ejecutar_limpieza();
            limpiar_base();
        }

        public void limpiar_base()
        {
            string consulta = "Execute PAGO_AGIL.LimpiarPagos";

            conexion connection = new conexion();
            SqlCommand command = new SqlCommand();

            command.CommandText = consulta;
            command.CommandType = CommandType.Text;
            command.Connection = connection.abrir_conexion();

            Object reader = command.ExecuteNonQuery();
        }

        public void ejecutar_limpieza()
        {
            dataGridView_total.Rows.Clear();
            dataGridView_confirmados.Rows.Clear();
            comboBox_cliente.Enabled = true;
            cargar_clientes("");
            cargar_empresas("");
            textBox_cliente.Text = "";
            textBox_empresa.Text = "";
            label_cant.Text = "0";
            label_total.Text = "0";
            cantidad_fact = 0;
            monto_total = 0;
            comboBox_forma.SelectedIndex = -1;
        }

        private void button_confirmar_Click(object sender, EventArgs e)
        {
            if (comboBox_forma.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una forma de pago");
            }
            else
            {
                string consulta = "Execute PAGO_AGIL.RegistrarPago '" + textBox_fecha_sistema.Text + "', '" + monto_total + "', '" + comboBox_forma.Text + "', '" + textBox_sucursal.Text + "', '" + usuario + "'";

                conexion connection = new conexion();
                SqlCommand command = new SqlCommand();

                command.CommandText = consulta;
                command.CommandType = CommandType.Text;
                command.Connection = connection.abrir_conexion();

                Object reader = command.ExecuteNonQuery();

                MessageBox.Show("El pago se ha registrado correctamente");
                ejecutar_limpieza();
            }
        }
    }
}
