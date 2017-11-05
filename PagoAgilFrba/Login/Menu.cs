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

namespace PagoAgilFrba.Login
{
    public partial class Menu : Form
    {
        string menu_user;
        string menu_rol;
        string menu_fecha;
        string menu_sucursal;

        public Menu(string usuario, string rol, string fecha, string sucursal)
        {
            InitializeComponent();
            menu_user = usuario;
            menu_rol = rol;
            menu_fecha = fecha;
            menu_sucursal = sucursal;
            label_usuario.Text = "Rol: " + rol + "      Usuario: " + usuario;
            label_fecha.Text = sucursal + "      Fecha de sistema: " + fecha;
            habilitar_botones();
        }

        private void habilitar_botones()
        {
            button_pagar.Hide();//  .Visible = false;
            button_rendir.Hide();//  .Visible = false;
            button_abm_cliente.Hide();//  .Visible = false;
            button_abm_empresa.Hide();//  .Visible = false;
            button_abm_facturas.Hide();//  .Visible = false;
            button_abm_rol.Hide();//  .Visible = false;
            button_abm_sucursal.Hide();//  .Visible = false;
            button_estadisticas.Hide();//  .Visible = false;

            string cadena = "Select Distinct Funcionalidad from PAGO_AGIL.Vw_User_Info where ";
            cadena = cadena + "Usuario like '" + menu_user + "'";
            cadena = cadena + " and Rol like '" + menu_rol + "'";

            conexion connection = new conexion();
            SqlCommand command = new SqlCommand();

            command.CommandText = cadena;
            command.CommandType = CommandType.Text;
            command.Connection = connection.abrir_conexion();

            try
            {
                SqlDataReader reader = command.ExecuteReader();
                mostrar_botones(reader);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void mostrar_botones(SqlDataReader lista)
        {
            string funcion;
            
            while(lista.Read())
            {
                funcion = lista[0].ToString();

                if (funcion == "ABM de Rol")
                {
                    button_abm_rol.Show();// .Visible = true;
                }
                else if (funcion == "ABM de Cliente")
                {
                    button_abm_cliente.Show();// .Visible = true;
                }
                else if (funcion == "ABM de Empresa")                        
                {
                    button_abm_empresa.Show();// .Visible = true;
                }
                else if (funcion == "ABM de Sucursal")
                {
                    button_abm_sucursal.Show();// .Visible = true;
                }    
                else if (funcion == "ABM Facturas")
                {
                    button_abm_facturas.Show();// .Visible = true;
                }
                else if (funcion == "Registro de Pago de Facturas")
                {
                    button_pagar.Show();// .Visible = true;
                }    
                else if (funcion == "Rendicion de Facturas cobradas")
                {
                    button_rendir.Show();// .Visible = true;
                }
                else if (funcion == "Listado Estadistico")
                {
                    button_estadisticas.Show();// .Visible = true;
                }
            }
        }

        private void button_salir_Click(object sender, EventArgs e)
        {
            //this.Close();
            System.Windows.Forms.Application.Exit();
        }

        private void button_rendir_Click(object sender, EventArgs e)
        {
            PagoAgilFrba.Rendicion.Rendicion rendicion = new PagoAgilFrba.Rendicion.Rendicion(menu_user, menu_fecha, this);
            this.Hide();
            rendicion.Show();
        }
    }
}
