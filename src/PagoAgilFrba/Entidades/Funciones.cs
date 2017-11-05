using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using PagoAgilFrba.Entidades;
using System.Data;
using System.Configuration;
using System.Web;
using System.Xml.Linq;

namespace PagoAgilFrba.Entidades
{
    class Herramientas
    {
        public Herramientas()
        {
     
        }

        public static void llenarComboBox(ComboBox cb, string consulta)
        {
            SqlDataReader dReader;
            try
            {
                conexion cn = new conexion();
                cn.abrir_conexion();

                SqlCommand query = new SqlCommand(consulta, cn.abrir_conexion());
                dReader = query.ExecuteReader();

                while (dReader.Read())
                {
                    cb.Items.Add(dReader[0]);
                }
                dReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar el combo Box " + ex.ToString());
            }
        }

        public static DataTable EjecutarStoredProcedureSinParametros(string nombreSP)
        {
            try
            {
                DataTable dtable = new DataTable();
                conexion conection = new conexion();
                SqlCommand query = new SqlCommand(nombreSP, conection.abrir_conexion());
                query.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(query);
                da.Fill(dtable);

                return dtable;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString(), "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            }
        }

        public static SqlDataReader ejecutarConsultaSimple(string consulta)
        {
            try
            {
                SqlDataReader dReader;
                conexion cn = new conexion();

                SqlCommand query = new SqlCommand(consulta, cn.abrir_conexion());
                dReader = query.ExecuteReader();

                return dReader;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex.Message);
                return null;
            }
        }

        public static DataTable EjecutarStoredProcedure(string nombreSP, List<SqlParameter> parametros)
        {
            try
            {
                DataTable dtable = new DataTable();
                conexion conection = new conexion();
                SqlCommand query = new SqlCommand(nombreSP, conection.abrir_conexion());
                query.CommandType = CommandType.StoredProcedure;
                //paso lo parametros como array
                query.Parameters.AddRange(parametros.ToArray());
                SqlDataAdapter da = new SqlDataAdapter(query);
                da.Fill(dtable);

                return dtable;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            }
        }

        public static int ejec_SP_NOQUERY(string noquery, List<SqlParameter> lista)
        {
            conexion conection = new conexion();
            SqlCommand query = new SqlCommand(noquery, conection.abrir_conexion());
            query.CommandType = CommandType.StoredProcedure;
            //paso lo parametros como array
            query.Parameters.AddRange(lista.ToArray());
            try
            {
                int filas_afectadas = query.ExecuteNonQuery();
                return filas_afectadas;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

        }

        public static List<SqlParameter> GenerarListaDeParametros(params object[] values)
        {
            if (values.Length % 2 != 0)
            {
                throw new ArgumentException("La cantidad de argumentos no puede ser impar " +
                    "ya que son pares clave-valor");
            }
            List<SqlParameter> paramList = new List<SqlParameter>();
            for (int i = 0; i < values.Length; i++)
            {
                if (i % 2 == 0)
                {
                    String nombreParam = values[i].ToString();
                    object paramValue = values[i + 1];
                    paramList.Add(new SqlParameter(nombreParam, paramValue));
                }
            }
            return paramList;
        }
    }
}
