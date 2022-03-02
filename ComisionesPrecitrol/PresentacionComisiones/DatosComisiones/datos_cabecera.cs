using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosComisiones
{
    public class Datos_Cabecera
    {
        SqlConnection ConexionSql = null;
        SqlCommand ComandoSql = null;
        String query = null;
        SqlDataReader LectorDatos = null;
        SqlDataAdapter AdaptadorSql = null;
        DataSet DatoAlmacenado = null;
        private Datos_Conexion CadenaSql = new Datos_Conexion();

        public int Insertas_Cabecera(string Cab_NFactura, string Cab_Estado, string Cab_FEmision, string Cab_FVencimiento, string Cab_RazonSocial, string Cab_RazonSocial2, string Cab_Valor, string Cab_Ruc, string Recibo_Cobro)
        {
            int Respuesta;
            try
            {
                using (ConexionSql = new SqlConnection(CadenaSql.String_Conexion()))
                {
                    ComandoSql = new SqlCommand("exec P_Cabecera '" + Cab_NFactura + "', '" + Cab_Estado + "', '" + Convert.ToDateTime(Cab_FEmision).ToString("yyyy-MM-dd") + "' , '" + Convert.ToDateTime(Cab_FVencimiento).ToString("yyyy-MM-dd") + "','" + Cab_RazonSocial + "','" + Cab_RazonSocial2 + "','" + Cab_Valor.Replace(",", "") + "','" + Cab_Ruc + "'," + Recibo_Cobro + "", ConexionSql);
                    ConexionSql.Open();
                    Respuesta = ComandoSql.ExecuteNonQuery();
                    ConexionSql.Close();
                }
            }

            finally
            {
                if (ConexionSql != null && ConexionSql.State != ConnectionState.Closed)
                {
                    ConexionSql.Close();
                }
            }
            return Respuesta;
        }


        public bool Consulta_Factura(string NFactura)
        {

            string Respuesta;
            try
            {
                using (ConexionSql = new SqlConnection(CadenaSql.String_Conexion()))
                {
                    ComandoSql = new SqlCommand("SELECT TOP 1 COUNT(Cab_NFactura)  FROM Cabecera WHERE Cab_NFactura='" + NFactura + "'", ConexionSql);
                    ConexionSql.Open();
                    Respuesta = Convert.ToString(ComandoSql.ExecuteScalar());
                    ConexionSql.Close();
                }

                if (Respuesta.Equals("0"))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            finally
            {
                if (ConexionSql != null && ConexionSql.State != ConnectionState.Closed)
                {
                    ConexionSql.Close();
                }
            }
        }


        public bool Consulta_FacturaM(string NFactura)
        {

            string Respuesta;
            try
            {
                using (ConexionSql = new SqlConnection(CadenaSql.String_Conexion()))
                {
                    ComandoSql = new SqlCommand("SELECT TOP 1 COUNT(Cab_NFactura)  FROM Cabecera_M WHERE Cab_NFactura='" + NFactura + "'", ConexionSql);
                    ConexionSql.Open();
                    Respuesta = Convert.ToString(ComandoSql.ExecuteScalar());
                    ConexionSql.Close();
                }

                if (Respuesta.Equals("0"))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            finally
            {
                if (ConexionSql != null && ConexionSql.State != ConnectionState.Closed)
                {
                    ConexionSql.Close();
                }
            }
        }
    }
}