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

namespace PagoAgilFrba.AbmSucursal
{
    public partial class auxiliarModificacion : Form
    {
        private Form anterior;
        private DataGridViewRow row;
        private int reh;
        private string est;
        private string name;
        private string dir;
        private string cpa;

        public auxiliarModificacion(Form an, DataGridViewRow rowia)
        {
            InitializeComponent();
            anterior = an;
            row = rowia;
            nombre.Text = name = row.Cells["Sucursal_Nombre"].Value.ToString();
            direccion.Text = dir = row.Cells["Sucursal_Direccion"].Value.ToString();
            cp.Text = cpa = row.Cells["Sucursal_Codigo_Postal"].Value.ToString();
            est = row.Cells["Sucursal_Estado"].Value.ToString();
            if (est == "True") { label4.Hide(); habilitar.Hide(); reh = 1; } else { reh = 0; }

            nombre.ReadOnly = true;
            direccion.ReadOnly = true;
            cp.ReadOnly = true;

        }

        private void cp_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            //Controla que el valor ingresado sea un numerico
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void modificar_Click(object sender, EventArgs e)
        {
            if ((nombre.Text == "") || (direccion.Text == "") || (cp.Text == ""))
            {
                MessageBox.Show("no puede haber campos sin completar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool nok = true, dok = true, cpok = true;
                validar(nok, dok, cpok);
                if (!nok)
                {
                    MessageBox.Show("Nombre hasta 50 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!dok)
                {
                    MessageBox.Show("Direccion hasta 50 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (!cpok)
                {
                    MessageBox.Show("El código postal debe ser distinto de cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    conexion connection = new conexion();
                    SqlCommand command = new SqlCommand("PAGO_AGIL.modificar_sucursal");
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@nombreant", name);
                    command.Parameters.AddWithValue("@direccionant", dir);
                    command.Parameters.AddWithValue("@cpant", int.Parse(cpa));
                    command.Parameters.AddWithValue("@nombrenuev", nombre.Text);
                    command.Parameters.AddWithValue("@direccionnuev", direccion.Text);
                    command.Parameters.AddWithValue("@cpnuev", int.Parse(cp.Text));
                    command.Parameters.AddWithValue("@habilitar", reh);
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
                            MessageBox.Show("Ya existe sucursal con ése código postal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else
                        {
                            MessageBox.Show("Modificaciones realizadas exitosamente", "Modificar Sucursal", MessageBoxButtons.OK, MessageBoxIcon.None);
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

        private void habilitar_Click(object sender, EventArgs e)
        {
            reh = 1;

        }

        private void validar(bool nameok, bool dirok, bool cpok)
        {
            if (nombre.TextLength > 50) { nameok = false; }
            if (direccion.TextLength > 50) { dirok = false; }
            if (cp.Text != "") { if (int.Parse(cp.Text) <= 0) { cpok = false; }; }

        }

        private void nombre_Click(object sender, MouseEventArgs e)
        {
            nombre.ReadOnly = false;
        }

        private void direccion_Click(object sender, MouseEventArgs e)
        {
            direccion.ReadOnly = false;
        }

        private void cp_Click(object sender, MouseEventArgs e)
        {
            cp.ReadOnly = false;
        }

    }
}
