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

namespace PagoAgilFrba.AbmEmpresa
{
    public partial class Buscador_Empresa : Form
    {
        public Buscador_Empresa()
        {
            InitializeComponent();
            string consulta = "Select Rubro_Descripcion from PAGO_AGIL.Dim_Rubro";
            Entidades.Herramientas.llenarComboBox(combo_rubro, consulta);
        }

        private void button_buscar_Click(object sender, EventArgs e)
        {
            string consulta = "Select * from PAGO_AGIL.Vw_Empresa where 1 = 1 ";

            if (!string.IsNullOrWhiteSpace(textBox_nombre.Text)) 
            {
                consulta = consulta + "and Empresa_Nombre LIKE '%" + textBox_nombre.Text + "%' ";
            }
            if (!string.IsNullOrWhiteSpace(textBox_cuit.Text))
            {
                consulta = consulta + "and Empresa_Cuit LIKE '%" + textBox_cuit.Text + "%' ";
            }
            if (combo_rubro.SelectedIndex != -1)
            {
                consulta = consulta + "and Rubro LIKE '%" + combo_rubro.Text + "%'";
            }

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

        private void cargar_datos(SqlDataReader datos)
        {
            dataGridView.Rows.Clear();

            List<DataGridViewRow> filas = new List<DataGridViewRow>();
            Object[] columnas = new Object[6];

            while (datos.Read())
            {
                columnas[0] = datos["Empresa_Id"].ToString();
                columnas[1] = datos["Empresa_Nombre"].ToString();
                columnas[2] = datos["Empresa_Cuit"].ToString();
                columnas[3] = datos["Empresa_Direccion"].ToString();
                columnas[4] = datos["Rubro"].ToString();
                columnas[5] = datos["Habilitado"].ToString();

                filas.Add(new DataGridViewRow());
                filas[filas.Count - 1].CreateCells(dataGridView, columnas);
            }

            dataGridView.Rows.AddRange(filas.ToArray());
        }

        private void Buscador_Empresa_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gD2C2017DataSet.Dim_Empresa' Puede moverla o quitarla según sea necesario.
            this.dim_EmpresaTableAdapter.Fill(this.gD2C2017DataSet.Dim_Empresa);
            // TODO: esta línea de código carga datos en la tabla 'gD2C2017DataSet.Vw_Empresa' Puede moverla o quitarla según sea necesario.
            this.vw_EmpresaTableAdapter.Fill(this.gD2C2017DataSet.Vw_Empresa);

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
