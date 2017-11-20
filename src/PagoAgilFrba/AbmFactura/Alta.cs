using PagoAgilFrba.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.AbmFactura
{
    public partial class Alta : Form
    {
        private string fechactual;
        public float total;
        public int itcount;
        public List<String> string_items;
        private Form anterior;

        public Alta(Form a)
        {   
            InitializeComponent();
            fechactual = factfechaalta.Text = ConfigurationManager.AppSettings["DateKey"];
            factvenc.Value = System.DateTime.ParseExact(fechactual, "dd/MM/yyyy HH:mm:ss", null);
            string empresasc = "Select distinct emp.Empresa_Nombre from PAGO_AGIL.Dim_Empresa as emp";
            Entidades.Herramientas.llenarComboBox(empresas,empresasc);
            string consultaclientes = "Select (cli.Cliente_Nombre + ',' + cli.Cliente_Apellido) from PAGO_AGIL.Lk_Cliente as cli order by cli.Cliente_Nombre";
            Entidades.Herramientas.llenarComboBox(clientes, consultaclientes);
            facttotal.Text = "0";
            total = 0;
            itcount = 0;
            empresas.Text = "";
            clientes.Text = "";
            factnro.Text = "";
            string_items = new List<string>();
            anterior = a;

        }

        private void agregar_Click(object sender, EventArgs e)
        {
            if (clientes.Text == "" || empresas.Text == "" || factnro.Text == "")
            {
                MessageBox.Show("no puede haber campos sin completar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);            
            }else
            {
                if (int.Parse(factnro.Text) <= 0)
                {
                    MessageBox.Show("El numero de factura debe ser mayor a cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);            
            
                }
                else if (itcount == 0)
                {
                    MessageBox.Show("La factura debe tene al menos 1 item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    conexion connection = new conexion();
                    SqlCommand command = new SqlCommand("PAGO_AGIL.alta_factura");
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@nro", int.Parse(factnro.Text));
                    command.Parameters.AddWithValue("@alta", fechactual);
                    command.Parameters.AddWithValue("@venc", factvenc.Value.ToString());
                    command.Parameters.AddWithValue("@empr", empresas.Text);
                    command.Parameters.AddWithValue("@clie", clientes.Text);
                    var returnParameter = command.Parameters.Add("@ret", SqlDbType.Int);
                    returnParameter.Direction = ParameterDirection.ReturnValue;
                    command.Connection = connection.abrir_conexion();
                    try
                    {

                        command.ExecuteNonQuery();
                        int resultado = int.Parse(returnParameter.Value.ToString());

                        connection.cerrar_conexion(command.Connection);

                        if (resultado == -1)
                        {
                            MessageBox.Show("Ya existe Nro factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else if (resultado == -2)
                        {
                            MessageBox.Show("La fecha de vencimiento debe ser mayor a la de alta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else
                        {
                            this.agregar_items(resultado);
                            this.calcular_monto_final(resultado);
                            MessageBox.Show("Factura agregada", "Modificar Sucursal", MessageBoxButtons.OK, MessageBoxIcon.None);
                            anterior.Show();
                            this.Close();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }

                   
                }
                
            }

        }

        private void factnro_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            //Controla que el valor ingresado sea un numerico
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void items_Click(object sender, EventArgs e)
        {
            item it = new PagoAgilFrba.AbmFactura.item(this);
            it.Show();
            this.Hide();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            anterior.Show();
            this.Close();
        }

        private void agregar_items(int idfactura)
        {
            conexion connection = new conexion();
            SqlCommand command = new SqlCommand("PAGO_AGIL.alta_item_fact");
            command.CommandType = CommandType.StoredProcedure;

            foreach (string item in string_items)
            {
                string cantidad = Regex.Split(item," - ")[0];
                string precio= Regex.Split(item," - ")[1];

                command.Parameters.AddWithValue("@cant", int.Parse(cantidad));
                command.Parameters.AddWithValue("@monto", precio);
                command.Parameters.AddWithValue("@idfac", idfactura);

                command.Connection = connection.abrir_conexion();
                command.ExecuteNonQuery();
                command.Parameters.Clear();
                connection.cerrar_conexion(command.Connection);
                
            }
        }

        private void calcular_monto_final(int facid)
        {
            conexion connection = new conexion();
            SqlCommand command = new SqlCommand("PAGO_AGIL.calcular_fact_total");
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idfac", facid);
            command.Connection = connection.abrir_conexion();
            command.ExecuteNonQuery();
            connection.cerrar_conexion(command.Connection);

        }

        public float getTotal()
        {
            return total;
        }
        public void setTotal(float n)
        {
            total = n;
        }
        public int getCount()
        {
            return itcount;
        }
        public void setCount(int n)
        {
            itcount = n;
        }

    }
}
