using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosComisiones
{
    public class Datos_Porcentaje
    {
        SqlConnection ConexionSql = null;
        SqlCommand ComandoSql = null;
        String query = null;
        SqlDataReader LectorDatos = null;
        SqlDataAdapter AdaptadorSql = null;
        DataSet DatoAlmacenado = null;
        private Datos_Conexion CadenaSql = new Datos_Conexion();

        public int Insertas_Porcentaje(String Par_NFactura,String Emp_Codigo, String Par_Fecha, String Par_Categoria, String Par_Porcentaje, String Par_Detalle
                                       , String Par_VNeto, String Par_CentroCostos, String Par_RazonSocial
                                      )
        {
            int Respuesta;
            try
            {
                using (ConexionSql = new SqlConnection(CadenaSql.String_Conexion()))
                {
                    //ComandoSql = new SqlCommand("exec P_Cabecera '" + Cab_NFactura + "', '" + Cab_Estado + "', '" + Convert.ToDateTime(Cab_FEmision).ToString("yyyy-MM-dd") + "' , '" + Convert.ToDateTime(Cab_FVencimiento).ToString("yyyy-MM-dd") + "','" + Cab_RazonSocial + "','" + Cab_RazonSocial2 + "','" + Cab_Valor.Replace(",", "") + "','" + Cab_Ruc + "'," + Recibo_Cobro + "", ConexionSql);
                    ComandoSql = new SqlCommand("exec P_Participacion '" + Par_NFactura + "', '" + Emp_Codigo + "', '" + Convert.ToDateTime(Par_Fecha).ToString("yyyy-MM-dd") + "' , '" + Par_Categoria + "','" + Par_Porcentaje + "','" + Par_Detalle + "','" + Par_VNeto.Replace(",", "") + "','" + Par_CentroCostos + "','A','"+ Par_RazonSocial + "'", ConexionSql);

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


        public DataSet Porcentajes_Participacion(string[] datos_Consulta)
        {
            DataSet Dato_Almacenado = new DataSet();
            string consulta = "";
            try
            {
                
                    //cargamos todas las Facturas
                    consulta = " SELECT * FROM    V_Participacion WHERE CONVERT(DATE,Par_Fecha,103) BETWEEN  CONVERT(DATE,'"+datos_Consulta[0]+ "',103) AND CONVERT(DATE,'" + datos_Consulta[1] + "',103) ORDER BY Año, mes, Par_Categoria";
                
                using (ConexionSql = new SqlConnection(CadenaSql.String_Conexion()))
                {
                    ConexionSql.Open();
                    SqlCommand Comando_Sql = new SqlCommand(consulta, ConexionSql);
                    SqlDataAdapter Adaptador_Sql = new SqlDataAdapter(Comando_Sql);
                    // ccn.Open()
                    Adaptador_Sql.Fill(Dato_Almacenado);
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
            return Dato_Almacenado;
        }




    }
}
