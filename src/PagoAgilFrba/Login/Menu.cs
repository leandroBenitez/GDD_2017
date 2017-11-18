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

        private void button_abm_empresa_Click(object sender, EventArgs e)
        {
            PagoAgilFrba.AbmEmpresa.Menu menu_abm_empre = new PagoAgilFrba.AbmEmpresa.Menu(this);
            this.Hide();
            menu_abm_empre.Show();
        }

        private void button_abm_rol_Click(object sender, EventArgs e)
        {
            PagoAgilFrba.AbmRol.Menu menu_abm_rol = new PagoAgilFrba.AbmRol.Menu(this);
            this.Hide();
            menu_abm_rol.Show();
        }

        private void button_pagar_Click(object sender, EventArgs e)
        {
            PagoAgilFrba.RegistroPago.RegistroPago menu_reg = new PagoAgilFrba.RegistroPago.RegistroPago(menu_fecha, menu_sucursal, this);
            this.Hide();
            menu_reg.Show();
        }

        private void button_estadisticas_Click(object sender, EventArgs e)
        {
            PagoAgilFrba.ListadoEstadistico.estadisticas estad = new PagoAgilFrba.ListadoEstadistico.estadisticas(this);
            this.Hide();
            estad.Show();
        }

        private void button_abm_sucursal_Click(object sender, EventArgs e)
        {
            PagoAgilFrba.AbmSucursal.Menu sucu = new PagoAgilFrba.AbmSucursal.Menu(this);
            this.Hide();
            sucu.Show();
        }

        private void button_abm_facturas_Click(object sender, EventArgs e)
        {
            PagoAgilFrba.AbmFactura.Menu alta = new PagoAgilFrba.AbmFactura.Menu(this);
            this.Hide();
            alta.Show();
        }

        private void button_abm_cliente_Click(object sender, EventArgs e)
        {
            PagoAgilFrba.AbmCliente1.mainABMClie cli = new PagoAgilFrba.AbmCliente1.mainABMClie(this);
            this.Hide();
            cli.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
