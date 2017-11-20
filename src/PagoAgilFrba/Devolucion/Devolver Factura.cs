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

namespace PagoAgilFrba.Devolucion
{
    public partial class DevolverFactura : Form
    {
        private Form anterior;
        private string sfecha;
        private string user;
        private int facNumero;
        private string facEmpresa;

        public DevolverFactura(Form a, string usuario)
        {
            InitializeComponent();
            user = usuario;
            sfecha = ConfigurationManager.AppSettings["DateKey"];
            pickalta.Value = pickvenc.Value = pickvenc.MinDate;
            string empresasc = "Select distinct emp.Empresa_Nombre from PAGO_AGIL.Dim_Empresa as emp";
            Entidades.Herramientas.llenarComboBox(empresas, empresasc);
            string consultaclientes = "Select (cli.Cliente_Nombre + ',' + cli.Cliente_Apellido) from PAGO_AGIL.Lk_Cliente as cli order by cli.Cliente_Nombre";
            Entidades.Herramientas.llenarComboBox(clientes, consultaclientes);

            pickalta.CustomFormat = pickvenc.CustomFormat = " ";
            pickalta.Format = pickvenc.Format = DateTimePickerFormat.Custom;
            anterior = a;
            empresas.Text = "";
            clientes.Text = "";
            facnum.Text = "";
            empresas.SelectedIndex = -1;
            clientes.SelectedIndex = -1;
            dataGridView1.Rows.Clear();
        }

        private void buscar_Click(object sender, EventArgs e)
        {
             int num = 0;
            string v;
            string a;
            if (facnum.Text != "") num = int.Parse(facnum.Text);
            if (pickvenc.Value == pickvenc.MinDate) v = ""; else v = pickvenc.Value.ToString();
            if (pickalta.Value == pickvenc.MinDate) a = ""; else a = pickalta.Value.ToString();
            conexion connection = new conexion();
             SqlCommand command = new SqlCommand("[PAGO_AGIL].buscar_factura");
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@numero", num);
            command.Parameters.AddWithValue("@alta", a);
            command.Parameters.AddWithValue("@venc",v);
            command.Parameters.AddWithValue("@clie", clientes.Text);
            command.Parameters.AddWithValue("@emp", empresas.Text);
            command.Parameters.AddWithValue("@estado", 1); // Facturas Pagas 
            var returnParameter = command.Parameters.Add("@ret", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;
            command.Connection = connection.abrir_conexion();

            try
            {
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows == false)
                {

                    if (returnParameter.Value != null)
                    {
                        MessageBox.Show("No existe factura con ese numero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        MessageBox.Show("No hay facturas pagas con tales filtros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
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
            if (e.RowIndex >= 0 && e.ColumnIndex == 6)
            {

                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                facNumero = int.Parse(row.Cells["Numero"].Value.ToString());
                facEmpresa = row.Cells["Empresa"].Value.ToString();

                PagoAgilFrba.Devolucion.motivo n = new PagoAgilFrba.Devolucion.motivo(this);
                n.Show();
                this.limpiar_c();
                this.Enabled = false;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            anterior.Show();
            this.Close();

        }

        private void pickalta_ValueChanged(object sender, EventArgs e)
        {
            pickalta.Format = DateTimePickerFormat.Short;
        }

        private void pickvenc_ValueChanged(object sender, EventArgs e)
        {
            pickvenc.Format = DateTimePickerFormat.Short;
        }


        public void limpiar_Click(object sender, EventArgs e)
        {
            pickalta.Value = pickvenc.Value = System.DateTime.ParseExact(sfecha, "dd/MM/yyyy HH:mm:ss", null);
            empresas.Text = "";
            clientes.Text = "";
            facnum.Text = "";
            pickalta.Value = pickvenc.Value = pickvenc.MinDate;
            pickalta.CustomFormat = pickvenc.CustomFormat = " ";
            pickalta.Format = pickvenc.Format = DateTimePickerFormat.Custom;
            empresas.SelectedIndex = -1;
            clientes.SelectedIndex = -1;
            dataGridView1.Rows.Clear();
        }

        public void limpiar_c()
        {
            pickalta.Value = pickvenc.Value = System.DateTime.ParseExact(sfecha, "dd/MM/yyyy HH:mm:ss", null);
            empresas.Text = "";
            clientes.Text = "";
            facnum.Text = "";
            pickalta.Value = pickvenc.Value = pickvenc.MinDate;
            pickalta.CustomFormat = pickvenc.CustomFormat = " ";
            pickalta.Format = pickvenc.Format = DateTimePickerFormat.Custom;
            empresas.SelectedIndex = -1;
            clientes.SelectedIndex = -1;
            dataGridView1.Rows.Clear();
        }


        public string getUser()
        {
            return user;
        }
        public string getEmpresa()
        {
            return facEmpresa;
        }
        public int getFactNumero()
        {
            return facNumero;
        }

        
    }
}
