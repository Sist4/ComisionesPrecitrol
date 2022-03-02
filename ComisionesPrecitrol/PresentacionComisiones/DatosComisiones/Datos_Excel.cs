using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosComisiones
{
   public class Datos_Excel
    {
        SqlConnection ConexionSql = null;
        SqlCommand ComandoSql = null;
        String query = null;
        SqlDataReader LectorDatos = null;
        SqlDataAdapter AdaptadorSql = null;
        DataSet DatoAlmacenado = null;
        private Datos_Conexion CadenaSql = new Datos_Conexion();

        public DataSet Cargar_InformacionExcel()//Cargamos los datos de la tabla Tipo_Comision
        {
            DataSet Dato_Almacenado = new DataSet();
            string consulta;
            try
            {
                
                consulta = "WITH Pivoted " +
                            "AS" +
                            "(" +
                             " SELECT *" +
                              "FROM V_ComisionU" +
                              "PIVOT " +
                              "( " +
                               " sum(DETC_TotalComision) FOR detc_tipoComision IN ( " +
	                            "												  [C. Mano de Obra]," +
	                            "												  [C. Software y Diseño]," +
	                            "												  [C. Metrología]," +
	                            "												  [REPUESTOS]," +
	                            "												  [MATERIALES]," +
	                            "												  [Z.NO.USAR.OTROS REPUESTOS]," +
	                            "												  [Z.NO.USAR.PARTES Y PIEZAS]," +
	                            "												  [Z.NO.USAR.CAMIONERAS]," +
	                            "												  [C. Repuestos Stock]," +
	                            "												  [Comision Ventas]," +
	                            "												  [PROYECTOS SERVICIOS]," +
	                            "												  [MANO DE OBRA CONTRATADA]" + 
	                            "												  )" +
                                ") AS p" +
                                ") " +
                                "SELECT" + 
                                "Pivoted.Emp_Codigo," +
                                "Pivoted.Emp_Nombre," +
                             "case when  SUM(Pivoted.[C. Mano de Obra])		is null  then 0 else SUM(Pivoted.[C. Mano de Obra])		end  AS Comision_Mo," +
                             "case when  SUM(Pivoted.[C. Software y Diseño]) is null	 then 0 else SUM(Pivoted.[C. Software y Diseño]) end as Comisiones_Sistemas ," +
                             "case when  SUM(Pivoted.[C. Metrología])		is null  then 0 else SUM(Pivoted.[C. Metrología]) end  as Comisiones_Metrologia," +
                             "case when  (SUM(Pivoted.[REPUESTOS]) +SUM(Pivoted.[MATERIALES]) + sum ([Z.NO.USAR.OTROS REPUESTOS]) + sum(  [Z.NO.USAR.PARTES Y PIEZAS]) +sum( [Z.NO.USAR.CAMIONERAS])+ sum([C. Repuestos Stock])) is null then 0 else (SUM(Pivoted.[REPUESTOS]) +SUM(Pivoted.[MATERIALES]) + sum ([Z.NO.USAR.OTROS REPUESTOS]) + sum(  [Z.NO.USAR.PARTES Y PIEZAS]) +sum( [Z.NO.USAR.CAMIONERAS])+ sum([C. Repuestos Stock]))  end  as Comision_Repuestos," +
                             "case when  sum([Comision Ventas]) is null then 0 else sum([Comision Ventas]) end as Comisiones_Ventas," +
                             "case when  sum([PROYECTOS SERVICIOS]) is null then 0 else sum([PROYECTOS SERVICIOS]) end as Proyectos ," +
                                 "case when  sum([MANO DE OBRA CONTRATADA]) is null then 0 else sum([MANO DE OBRA CONTRATADA]) end as Mano_de_Obra_Contratada," +
                                "month(detc_fechaCreacion)" +
                            "FROM Pivoted" +
                             "where    month(detc_fechaCreacion) between '7' and '7' and  year(detc_fechaCreacion) between '2018' and '2018'" + 
                            "GROUP BY Pivoted.Emp_Codigo,Pivoted.Emp_Nombre,month(detc_fechaCreacion)";
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
