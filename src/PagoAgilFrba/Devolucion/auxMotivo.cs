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
using System.Configuration;

namespace PagoAgilFrba.Devolucion
{
    public partial class auxMotivo : Form
    {
        private Form anterior;
        private DevolverFactura final;
        private string fecha;
        private int caso;
        private const int NEW = 2;
        private const int OLD = 1;

        public auxMotivo(Form a,DevolverFactura b, int c)
        {
            InitializeComponent();
            fecha = ConfigurationManager.AppSettings["DateKey"];
            anterior = a;
            final = b;
            caso = c;
            switch (caso) {
                case NEW:
                    textMotivo.Show();
                    textMotivo.Text = "";
                    checkedListBox1.Hide();
                    break;
                case OLD: 
                    textMotivo.Hide();
                    checkedListBox1.Show();
                    completar_list_box();
                    break;
            }

        }

        private void completar_list_box()
        {
            string consulta = "select * from PAGO_AGIL.Dim_Motivo_Dev";
            SqlDataReader aux_resultados  = Herramientas.ejecutarConsultaSimple(consulta);
            while (aux_resultados.Read())
            {
                checkedListBox1.Items.Add(aux_resultados["Motivo_Dev_Desc"].ToString());
            }

        }


        private void cancelar_Click(object sender, EventArgs e)
        {
            anterior.Show();
            this.Close();
        }

        private void checkedListBox1_Click(object sender, EventArgs e)
        {
            checkedListBox1.Enabled = false;

        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            switch (caso)
            {
                case NEW:
                    if (textMotivo.Text == "")
                    {
                        MessageBox.Show("Ingrese una descripcion", "Motivo Devolucion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        conexion connection = new conexion();
                        SqlCommand command = new SqlCommand("PAGO_AGIL.nueva_devolucion");
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idDev_mot", 0);
                    command.Parameters.AddWithValue("@desc", textMotivo.Text);
                    command.Parameters.AddWithValue("@f",fecha);
                    string user = final.getUser();
                    string empresa = final.getEmpresa();
                    int facnum = final.getFactNumero();
                    command.Parameters.AddWithValue("@responsable", user);
                    command.Parameters.AddWithValue("@facnro", facnum);
                    command.Parameters.AddWithValue("@empresa", empresa);
                    command.Connection = connection.abrir_conexion();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Devolución Realizada", "Motivo Devolución", MessageBoxButtons.OK, MessageBoxIcon.None);
                    
                    anterior.Close();
                    final.Enabled = true;
                    this.Close();
                    }
                    

                    break;
                case OLD:
                    int id = 0;
                    if (checkedListBox1.CheckedItems.Count == 0)
                    {
                        MessageBox.Show("Debe seleccionar un elemento", "Motivo Devolución", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                    Object seleccion = checkedListBox1.CheckedItems[0];
                    SqlDataReader resultados = Herramientas.ejecutarConsultaSimple("select * from PAGO_AGIL.Dim_Motivo_Dev");
                    while(resultados.Read()){

                        if(seleccion.ToString() == resultados["Motivo_Dev_Desc"].ToString()){ id = int.Parse(resultados["Motivo_Dev_Id"].ToString()); }
                        
                    }

                    conexion connection = new conexion();
                    SqlCommand command = new SqlCommand("PAGO_AGIL.nueva_devolucion");
                    //@facnro int,@empresa nvarchar(100)
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idDev_mot", id);
                    command.Parameters.AddWithValue("@desc", "");
                    command.Parameters.AddWithValue("@f",fecha);
                    string user = final.getUser();
                    string empresa = final.getEmpresa();
                    int facnum = final.getFactNumero();
                    command.Parameters.AddWithValue("@responsable", user);
                    command.Parameters.AddWithValue("@facnro", facnum);
                    command.Parameters.AddWithValue("@empresa", empresa);

                    command.Connection = connection.abrir_conexion();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Devolución Realizada", "Motivo Devolución", MessageBoxButtons.OK, MessageBoxIcon.None);
                    anterior.Close();
                    final.Enabled = true;
                    this.Close();
                    }


                    break;

            }
        }
    }
}
