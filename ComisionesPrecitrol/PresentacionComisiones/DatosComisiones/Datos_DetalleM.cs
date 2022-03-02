using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosComisiones
{
   public class Datos_DetalleM
    {
        SqlConnection ConexionSql = null;
        SqlCommand ComandoSql = null;
        String query = null;
        SqlDataReader LectorDatos = null;
        SqlDataAdapter AdaptadorSql = null;
        DataSet DatoAlmacenado = null;
        private Datos_Conexion CadenaSql = new Datos_Conexion();

        public int Insertar_Detalle(string Det_Codigo, string Cab_NFactura, string Det_NTrabajo, string Det_Detalle, string Det_Categoria, string Det_Comentario, string Det_Cantidad, string Det_VUnitario, string Det_VNeto, string Det_Iva, string Det_TotalVenta, string C_Costo, string DATOS_ADICIONALES)
        {
            int Respuesta;
            try
            {
                using (ConexionSql = new SqlConnection(CadenaSql.String_Conexion()))
                {
                    ComandoSql = new SqlCommand("exec P_Detalle_M  '" + Det_Codigo + "', '" + Cab_NFactura + "',  '" + Det_NTrabajo + "',  '" + Det_Detalle + "',  '" + Det_Categoria + "',  '" + Det_Comentario + "',  '" + Det_Cantidad + "',  '" + Det_VUnitario + "',  '" + Det_VNeto + "',  '" + Det_Iva + "',  '" + Det_TotalVenta + "','" + C_Costo + "','" + DATOS_ADICIONALES + "'", ConexionSql);
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
        //FUNCION PARA LLAMAR EL REPORTE DE COBRANZA


        public DataSet Reporte_Cobranza(string Cobranza_desde, string Cobranza_hasta)
        {
            DataSet Dato_Almacenado = new DataSet();
            string consulta;
            try
            {
                consulta = "select * from V_Detalle_M where Cab_FEmision  between '" + Cobranza_desde + "' and '" + Cobranza_hasta + "' order by Det_CentroCostos";

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
