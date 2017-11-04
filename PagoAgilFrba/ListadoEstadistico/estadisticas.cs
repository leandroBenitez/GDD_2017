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

namespace PagoAgilFrba.ListadoEstadistico
{
    public partial class estadisticas : Form
    {
        public estadisticas()
        {
            InitializeComponent();
        }

        private void botonTopPagos_Click(object sender, EventArgs e)
        {
            string fechaInicio;
            string fechaFin;
            dataGridMontoRendido.Visible=false;
            dataGridCantPagos.Visible = true;
            switch (label1.Text)
            {
                case "1" : 
                    fechaInicio = comboBox1.Text + "-01-01" ;
                    fechaFin = comboBox1.Text + "-03-31";
                    label2.Text = fechaInicio;
                    label3.Text = fechaFin;
                    break;
                case "2":
                    fechaInicio = comboBox1.Text + "-04-01" ;
                    fechaFin = comboBox1.Text + "-06-30";
                    label2.Text = fechaInicio;
                    label3.Text = fechaFin;
                    break;
                case "3":
                    fechaInicio = comboBox1.Text + "-07-01";
                    fechaFin = comboBox1.Text + "-09-30";
                    label2.Text = fechaInicio;
                    label3.Text = fechaFin;
                    break;
                case "4":
                    fechaInicio = comboBox1.Text + "-10-01";
                    fechaFin = comboBox1.Text + "-12-31";
                    label2.Text = fechaInicio;
                    label3.Text = fechaFin;
                    break;
                default: MessageBox.Show("Debe seleccionar un trimestre");
                    break;
            }
                        string consulta = "Execute topCantidadPagos '" + label2.Text + "', '" + label3.Text + "'"; 
            conexion connection = new conexion();
            SqlCommand command = new SqlCommand();

            command.CommandText = consulta;
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            { label1.Text = "1"; }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            { label1.Text = "2"; }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            { label1.Text = "3"; }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            { label1.Text = "4"; }
        }

        private void cargar_datos(SqlDataReader datos)
        {
            dataGridCantPagos.Rows.Clear();

            List<DataGridViewRow> filas = new List<DataGridViewRow>();
            Object[] columnas = new Object[4];

            while (datos.Read())
            {
                columnas[0] = datos["Cliente_Nombre"].ToString();
                columnas[1] = datos["Cliente_Apellido"].ToString();
                columnas[2] = datos["Cliente_Dni"].ToString();
                columnas[3] = datos["cantidad_pagos"].ToString();

                filas.Add(new DataGridViewRow());
                filas[filas.Count - 1].CreateCells(dataGridCantPagos, columnas);
            }

            dataGridCantPagos.Rows.AddRange(filas.ToArray());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fechaInicio;
            string fechaFin;
            dataGridMontoRendido.Visible = true;
            switch (label1.Text)
            {
                case "1":
                    fechaInicio = comboBox1.Text + "-01-01";
                    fechaFin = comboBox1.Text + "-03-31";
                    label2.Text = fechaInicio;
                    label3.Text = fechaFin;
                    break;
                case "2":
                    fechaInicio = comboBox1.Text + "-04-01";
                    fechaFin = comboBox1.Text + "-06-30";
                    label2.Text = fechaInicio;
                    label3.Text = fechaFin;
                    break;
                case "3":
                    fechaInicio = comboBox1.Text + "-07-01";
                    fechaFin = comboBox1.Text + "-09-30";
                    label2.Text = fechaInicio;
                    label3.Text = fechaFin;
                    break;
                case "4":
                    fechaInicio = comboBox1.Text + "-10-01";
                    fechaFin = comboBox1.Text + "-12-31";
                    label2.Text = fechaInicio;
                    label3.Text = fechaFin;
                    break;
                default: MessageBox.Show("Debe seleccionar un trimestre");
                    break;
            }
            string consulta = "Execute topMontoRendido '" + label2.Text + "', '" + label3.Text + "'";
            conexion connection = new conexion();
            SqlCommand command = new SqlCommand();

            command.CommandText = consulta;
            command.CommandType = CommandType.Text;
            command.Connection = connection.abrir_conexion();

            try
            {
                SqlDataReader reader = command.ExecuteReader();
                cargar_datos2(reader);
                connection.cerrar_conexion(command.Connection);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void cargar_datos2(SqlDataReader datos)
        {
            dataGridMontoRendido.Rows.Clear();

            List<DataGridViewRow> filas = new List<DataGridViewRow>();
            Object[] columnas = new Object[3];

            while (datos.Read())
            {
                columnas[0] = datos["Empresa_Nombre"].ToString();
                columnas[1] = datos["rubro"].ToString();
                columnas[2] = datos["monto_rendido"].ToString();

                filas.Add(new DataGridViewRow());
                filas[filas.Count - 1].CreateCells(dataGridMontoRendido, columnas);
            }

            dataGridMontoRendido.Rows.AddRange(filas.ToArray());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string fechaInicio;
            string fechaFin;
            dataGridMontoRendido.Visible = true;
            switch (label1.Text)
            {
                case "1":
                    fechaInicio = comboBox1.Text + "-01-01";
                    fechaFin = comboBox1.Text + "-03-31";
                    label2.Text = fechaInicio;
                    label3.Text = fechaFin;
                    break;
                case "2":
                    fechaInicio = comboBox1.Text + "-04-01";
                    fechaFin = comboBox1.Text + "-06-30";
                    label2.Text = fechaInicio;
                    label3.Text = fechaFin;
                    break;
                case "3":
                    fechaInicio = comboBox1.Text + "-07-01";
                    fechaFin = comboBox1.Text + "-09-30";
                    label2.Text = fechaInicio;
                    label3.Text = fechaFin;
                    break;
                case "4":
                    fechaInicio = comboBox1.Text + "-10-01";
                    fechaFin = comboBox1.Text + "-12-31";
                    label2.Text = fechaInicio;
                    label3.Text = fechaFin;
                    break;
                default: MessageBox.Show("Debe seleccionar un trimestre");
                    break;
            }
            string consulta = "Execute topMontoRendido '" + label2.Text + "', '" + label3.Text + "'";
            conexion connection = new conexion();
            SqlCommand command = new SqlCommand();

            command.CommandText = consulta;
            command.CommandType = CommandType.Text;
            command.Connection = connection.abrir_conexion();

            try
            {
                SqlDataReader reader = command.ExecuteReader();
                cargar_datos3(reader);
                connection.cerrar_conexion(command.Connection);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void cargar_datos3(SqlDataReader datos)
        {
            dataGridPorcentajePago.Rows.Clear();

            List<DataGridViewRow> filas = new List<DataGridViewRow>();
            Object[] columnas = new Object[4];

            while (datos.Read())
            {
                columnas[0] = datos["Dni_Cliente"].ToString();
                columnas[1] = datos["ApellidoCliente"].ToString();
                columnas[2] = datos["NombreCliente"].ToString();
                columnas[3] = datos["porcentaje_pago"].ToString();
                filas.Add(new DataGridViewRow());
                filas[filas.Count - 1].CreateCells(dataGridPorcentajePago, columnas);
            }

            dataGridPorcentajePago.Rows.AddRange(filas.ToArray());
        }

        private void botonTopFacturasEmpresa_Click(object sender, EventArgs e)
        {

        }
    }
}
