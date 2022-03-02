using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosComisiones
{
   public class Comision_V2
    {
        SqlConnection ConexionSql = null;
        SqlCommand ComandoSql = null;
        String query = null;
        SqlDataReader LectorDatos = null;
        SqlDataAdapter AdaptadorSql = null;
        DataSet DatoAlmacenado = null;
        private Datos_Conexion CadenaSql = new Datos_Conexion();


        public DataSet Cargar_ComisionesEmpleados()//Cargamos los datos de la tabla Tipo_Comision
        {
            DataSet Dato_Almacenado = new DataSet();
            string consulta;
            try
            {
                //consulta = "select * from V_Detalle where Det_NTrabajo like 'C.%'  and Det_estado !='P'  and Cab_Estado !='P'";
                consulta = "select * from V_Detalle where  Det_estado !='P'  and Cab_Estado !='P'";
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
