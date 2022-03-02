using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
namespace DatosComisiones
{
  public  class Datos_Empleados
    {
        SqlConnection ConexionSql = null;
        SqlCommand ComandoSql = null;
        String query = null;
        SqlDataReader LectorDatos = null;
        SqlDataAdapter AdaptadorSql = null;
        DataSet DatoAlmacenado = null;
        private Datos_Conexion CadenaSql = new Datos_Conexion();



        public DataSet Cargar_EmpleadosComisiones()//Cargamos los datos de la tabla Tipo_Comision
        {
            DataSet Dato_Almacenado = new DataSet();
            string consulta;
            try
            {
                consulta = "SELECT [Emp_Codigo] AS '#' ,[Emp_Nombre] AS 'NOMBRE DEL EMPLEADO' ,[Emp_Ciudad] AS 'CIUDAD' ,[Emp_Sueldo] AS 'SUELDO'"+
      ",[Emp_ComisionFija] * 100 AS 'COMISION FIJA',[Emp_ComisionManoObra] * 100 AS 'MANO DE OBRA',[Emp_ComisionRepuesto] * 100 AS 'COMISION REPUESTO'" +
      ",[Emp_Software] * 100 AS 'COMISION SOFTWARE',[Emp_ComisionMetrologia] * 100 AS 'METROLOGIA',[Emp_TotalMOUIO] * 100 AS 'Total de M/O UIO'" +
      ",[Emp_TotalMetrologiaUIO] * 100 AS 'Total M/O Metrologia UIO',[Emp_TotalRepuestosUIO]  * 100 AS 'Total de Repuestos y Materiales UIO'" +
      ",[Emp_TotalSWUIO]  * 100 AS 'Total SW y Diseño UIO',[Emp_TotalMOGYE] * 100 AS 'Total de M/O GYE',[Emp_TotalMetrologiaGYE] * 100 AS 'Total M/O Metrologia GYE'" +
      ",[Emp_TotalRepuestosGYE] * 100 AS 'Total de Repuestos y Materiales GYE',[Emp_TotalSWGYE] * 100 AS 'Total SW y Diseño GYE'" +
      ",[Emp_TotalMOMTA] * 100 AS 'Total de M/O MTA',[Emp_TotalMetrologiaMTA] * 100 AS 'Total M/O Metrologia MTA',[Emp_TotalRepuestosMTA] * 100 AS 'Total de Repuestos y Materiales MTA'" +
      " ,Emp_CodigoSafi FROM [dbo].[Empleados]";
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


        


              public int Codigo_Empleado()
              {
                  int Respuesta = 0;
                  try
                  {
                      using (ConexionSql = new SqlConnection(CadenaSql.String_Conexion()))
                      {
                          ComandoSql = new SqlCommand("SELECT  CASE WHEN  MAX(Emp_Codigo+1)IS NULL THEN 1 ELSE MAX(Emp_Codigo+1) END AS Codigo FROM Empleados", ConexionSql);
                          ConexionSql.Open();
                          Respuesta = Convert.ToInt32(ComandoSql.ExecuteScalar());
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
              public int Insertar_Empleados( String Emp_Codigo,String Emp_Nombre,String Emp_Ciudad ,String Emp_Sueldo ,String Emp_ComisionFija ,String Emp_ComisionManoObra  
                                               ,String Emp_ComisionRepuesto,String Emp_Software  ,String Emp_ComisionMetrologia  ,String Emp_TotalMOUIO  
                                               ,String Emp_TotalMetrologiaUIO ,String Emp_TotalRepuestosUIO,String Emp_TotalSWUIO ,String Emp_TotalMOGYE,String Emp_TotalMetrologiaGYE  
                                               ,String Emp_TotalRepuestosGYE ,String Emp_TotalSWGYE,String Emp_TotalMOMTA,String Emp_TotalMetrologiaMTA,String Emp_TotalRepuestosMTA  
                                               ,String Emp_Estado, string codigo_safi,string Correo   
                                            )
              {
                  int Respuesta;
                  try
                  {
                      using (ConexionSql = new SqlConnection(CadenaSql.String_Conexion()))
                      {
                          //ComandoSql = new SqlCommand("exec P_Empleados  '" + Emp_Codigo + "', '" + Emp_Nombre1 + "',  '" + Emp_Nombre2 + "',  '" + Emp_Apellido1 + "',  '" + Emp_Apellido2 + "',  '" + Emp_Ciudad + "',  '" + Emp_Sueldo + "',  '" + Emp_Estado + "',  '" + Comision_Fija + "',  '" + Comision_MO + "',  '" + Comision_Repuesto + "','" + Comision_Software + "','" + Comision_Metrologia + "'", ConexionSql);
                          ComandoSql = new SqlCommand("exec P_Empleados  '" + Emp_Codigo + "','" + Emp_Nombre+ "','" + Emp_Ciudad + "','" + Emp_Sueldo + "','" + Emp_ComisionFija + "','" + Emp_ComisionManoObra  
                                               + "','" + Emp_ComisionRepuesto+ "','" + Emp_Software  + "','" + Emp_ComisionMetrologia  + "','" + Emp_TotalMOUIO  
                                               + "','" + Emp_TotalMetrologiaUIO + "','" + Emp_TotalRepuestosUIO+ "','" + Emp_TotalSWUIO + "','" + Emp_TotalMOGYE+ "','" + Emp_TotalMetrologiaGYE  
                                               + "','" + Emp_TotalRepuestosGYE + "','" + Emp_TotalSWGYE+ "','" + Emp_TotalMOMTA+ "','" + Emp_TotalMetrologiaMTA+ "','" + Emp_TotalRepuestosMTA
                                               + "','" + Emp_Estado + "','" + codigo_safi + "','"  + Correo  + "'", ConexionSql);
                          
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





    }
}
