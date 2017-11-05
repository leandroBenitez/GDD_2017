using PagoAgilFrba.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.AbmSucursal
{
    public partial class Baja : Form
    {
        private Form anterior;

        public Baja(Form una)
        {
            InitializeComponent();
            anterior = una;
            nombre.Text = "";
            direccion.Text = "";
            cp.Text = "";
            estado.Text = "";
            this.Text = "Baja Sucursal";
            estado.Items.Add("Habilitada");
            estado.Items.Add("Deshabilitada");
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            nombre.Text = "";
            direccion.Text = "";
            cp.Text = "";
            estado.Text = "";
            estado.SelectedIndex = -1;
            dataGridView1.Rows.Clear();

        }

        private void buscarsuc_Click(object sender, EventArgs e)
        {
            string cadena = "select s.Sucursal_Nombre,s.Sucursal_Direccion,s.Sucursal_Codigo_Postal,s.Sucursal_Habilitado from PAGO_AGIL.Dim_Sucursal s where s.Sucursal_Nombre like '%'+'" + nombre.Text + "'+'%' and s.Sucursal_Direccion like '%'+'" + direccion.Text + "'+'%'";

            conexion connection = new conexion();
            SqlCommand command = new SqlCommand();

            if (cp.Text != "")
            {
                cadena = cadena + " and s.Sucursal_Codigo_Postal = " + cp.Text;
            }
            if (estado.Text != "")
            {
                int valor;
                if (estado.Text == "Habilitada") valor = 1; else valor = 0;
                cadena = cadena + " and s.Sucursal_Habilitado = " + valor;
            }
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

                DialogResult resultado = MessageBox.Show("   ¿Desea dar de baja la sucursal?", "Baja Sucursal", MessageBoxButtons.YesNo, MessageBoxIcon.None);
                if (resultado == DialogResult.Yes)
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    string nombrebaja = row.Cells["Sucursal_Nombre"].Value.ToString();
                    string direbaja = row.Cells["Sucursal_Direccion"].Value.ToString();
                    string cpbaja = row.Cells["Sucursal_Codigo_Postal"].Value.ToString();
                    string estadobaja = row.Cells["Sucursal_Estado"].Value.ToString();

                    if (estadobaja == "False")
                    {
                        MessageBox.Show(" La sucursal seleccionada ya se encuentra deshabilitada ", "Baja Sucursal", MessageBoxButtons.OK, MessageBoxIcon.None);

                    }
                    else
                    {
                        string consulta = "update PAGO_AGIL.Dim_Sucursal set Sucursal_Habilitado = 0 where Sucursal_Codigo_Postal = " + cpbaja + " and Sucursal_Direccion = '" + direbaja + "' and Sucursal_Nombre = '" + nombrebaja + "'";
                        conexion connection = new conexion();
                        SqlCommand command = new SqlCommand();
                        command.CommandText = consulta;
                        command.CommandType = CommandType.Text;
                        command.Connection = connection.abrir_conexion();

                        try
                        {
                            command.ExecuteNonQuery();
                            MessageBox.Show("  Hecho ", "Baja Sucursal", MessageBoxButtons.OK, MessageBoxIcon.None);
                            connection.cerrar_conexion(command.Connection);

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }


                    }
                }

                dataGridView1.CancelEdit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            anterior.Show();
            this.Close();
        }



    }
}
