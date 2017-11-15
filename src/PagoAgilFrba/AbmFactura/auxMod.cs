using PagoAgilFrba.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.AbmFactura
{
    public partial class auxMod : Form
    {
        private Form anterior;
        private DataGridViewRow row;
        private int num;
        private DateTime fecha_antes;


        public auxMod(Form a,DataGridViewRow r)
        {
            InitializeComponent();
            row = r;
            num = int.Parse(row.Cells["Numero"].Value.ToString());
            string f = row.Cells["Vencimiento"].Value.ToString();
            fecha_antes = System.DateTime.Parse(f);

            anterior = a;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
         
            if (fecha_antes.CompareTo(dateTimePicker1.Value) >= 0)
            {
                MessageBox.Show("El nuevo vencimiento tiene que ser mayor al anterior y diferente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                string conns = "update PAGO_AGIL.Lk_Factura set Factura_Fecha_Vencimiento = CONVERT(datetime,'" + dateTimePicker1.Value.ToString() + "',103) where Factura_Nro=" + num;


                conexion connection = new conexion();
                SqlCommand command = new SqlCommand();

                command.CommandText = conns;
                command.CommandType = CommandType.Text;
                command.Connection = connection.abrir_conexion();
                command.ExecuteNonQuery();
                MessageBox.Show("Exitos", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.None);
                anterior.Show();
                this.Close();

            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            anterior.Show();
            this.Close();
        }
    }
}
