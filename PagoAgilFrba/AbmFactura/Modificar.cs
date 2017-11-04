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
            pickalta.Value = pickvenc.Value = System.DateTime.ParseExact(sfecha, "dd/MM/yyyy HH:mm:ss", null);
            anterior = an;
            empresas.Text = "";
            clientes.Text = "";
            facnum.Text = "";
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
            string cadena = "select Factura_Nro,Factura_Fecha_Alta,Factura_Total,Factura_Fecha_Vencimiento,Factura_Cliente_Id,Factura_Empresa_Id,Factura_Rendicion_Id from PAGO_AGIL.Lk_Factura";

            conexion connection = new conexion();
            SqlCommand command = new SqlCommand();

            

            command.CommandText = cadena;
            command.CommandType = CommandType.Text;
            command.Connection = connection.abrir_conexion();

            try
            {
                SqlDataReader reader = command.ExecuteReader();
                cargar_datos(reader);
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
            Object[] columnas = new Object[4];

            while (reader.Read())
            {
                columnas[0] = reader["Sucursal_Nombre"].ToString();
                columnas[1] = reader["Sucursal_Direccion"].ToString();
                columnas[2] = reader["Sucursal_Codigo_Postal"].ToString();
                columnas[3] = reader["Sucursal_Habilitado"].ToString();

                filas.Add(new DataGridViewRow());
                filas[filas.Count - 1].CreateCells(dataGridView1, columnas);
            }

            dataGridView1.Rows.AddRange(filas.ToArray());
        }

        private void cp_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
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
