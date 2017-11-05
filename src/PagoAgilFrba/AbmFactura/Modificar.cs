using PagoAgilFrba.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.AbmFactura
{
    public partial class Modificar : Form
    {
        private Form anterior;
        private string sfecha;

        public Modificar(Form an)
        {
            InitializeComponent();
            sfecha =  ConfigurationManager.AppSettings["DateKey"];
            pickalta.Value = pickvenc.Value =pickvenc.MinDate;
            string empresasc = "Select distinct emp.Empresa_Nombre from PAGO_AGIL.Dim_Empresa as emp";
            Entidades.Herramientas.llenarComboBox(empresas, empresasc);
            string consultaclientes = "Select (cli.Cliente_Nombre + ',' + cli.Cliente_Apellido) from PAGO_AGIL.Lk_Cliente as cli order by cli.Cliente_Nombre";
            Entidades.Herramientas.llenarComboBox(clientes, consultaclientes);
            anterior = an;
            empresas.Text = "";
            clientes.Text = "";
            facnum.Text = "";
            empresas.SelectedIndex = -1;
            clientes.SelectedIndex = -1;
            dataGridView1.Rows.Clear();
            this.Text = "Modificar Factura";
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            pickalta.Value = pickvenc.Value = System.DateTime.ParseExact(sfecha, "dd/MM/yyyy HH:mm:ss", null);
            empresas.Text = "";
            clientes.Text = "";
            facnum.Text = "";
            empresas.SelectedIndex = -1;
            clientes.SelectedIndex = -1;
            dataGridView1.Rows.Clear();

        }

        private void buscarfactura_Click(object sender, EventArgs e)
        {
            int num = 0;
            string v;
            string a;
            if (facnum.Text != "") num = int.Parse(facnum.Text);
            if (pickvenc.Value == pickvenc.MinDate) v = ""; else v = pickvenc.Value.ToString();
            if (pickalta.Value == pickvenc.MinDate) a = ""; else a = pickalta.Value.ToString();
            conexion connection = new conexion();
            /* (@numero int,@alta varchar(50),@venc varchar(50),@clie nvarchar(255),@emp nvarchar(100))*/
            SqlCommand command = new SqlCommand("[PAGO_AGIL].buscar_factura");
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@numero", num);
            command.Parameters.AddWithValue("@alta", a);
            command.Parameters.AddWithValue("@venc",v);
            command.Parameters.AddWithValue("@clie", clientes.Text);
            command.Parameters.AddWithValue("@emp", empresas.Text);
            command.Connection = connection.abrir_conexion();

            try
            {
                SqlDataReader reader = command.ExecuteReader();
                if (reader.FieldCount == 1)
                {
                    MessageBox.Show("No existe factura con ese numero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cargar_datos(reader);
                
                }
                
                connection.cerrar_conexion(command.Connection);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void cargar_datos(SqlDataReader reader)
        {

            dataGridView1.Rows.Clear();

            List<DataGridViewRow> filas = new List<DataGridViewRow>();
            Object[] columnas = new Object[6];

            while (reader.Read())
            {
                columnas[0] = reader["Factura_Nro"].ToString();
                columnas[1] = reader["Factura_Fecha_Alta"].ToString();
                columnas[2] = reader["Factura_Fecha_Vencimiento"].ToString();
                columnas[3] = reader["Factura_Total"].ToString();
                columnas[4] = reader["clie"].ToString();
                columnas[5] = reader["emp"].ToString();

                filas.Add(new DataGridViewRow());
                filas[filas.Count - 1].CreateCells(dataGridView1, columnas);
            }

            dataGridView1.Rows.AddRange(filas.ToArray());
        }

        private void num_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            //Controla que el valor ingresado sea un numerico
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 4)
            {
                this.Hide();
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                PagoAgilFrba.AbmFactura.auxMod n= new PagoAgilFrba.AbmFactura.auxMod(this,row);
                n.Show();
                this.Hide();
                this.limpiar_Click(sender, e);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            anterior.Show();
            this.Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


    }
}
