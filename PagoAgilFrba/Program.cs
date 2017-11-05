using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace PagoAgilFrba
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PagoAgilFrba.Login.Login());
          // Application.Run(new PagoAgilFrba.RegistroPago.RegistroPago("Fecha Sistema", "Sucrsal"));
          // Application.Run(new PagoAgilFrba.AbmSucursal.Menu());
            //Application.Run(new PagoAgilFrba.AbmEmpresa.Buscador_Empresa());
            //Application.Run(new PagoAgilFrba.AbmFactura.Alta(new PagoAgilFrba.Login.Login()));
            //Application.Run(new PagoAgilFrba.ListadoEstadistico.estadisticas());
            //Application.Run(new PagoAgilFrba.AbmRol.BuscadorRol());
            //Application.Run(new PagoAgilFrba.AbmCliente1.mainABMClie());
        }
    }
}
