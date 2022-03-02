using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosComisiones
{
  public  class Datos_Comisiones
    {
        SqlConnection ConexionSql = null;
        SqlCommand ComandoSql = null;
        String query = null;
        SqlDataReader LectorDatos = null;
        SqlDataAdapter AdaptadorSql = null;
        DataSet DatoAlmacenado = null;
        private Datos_Conexion CadenaSql = new Datos_Conexion();
        public DataSet Cobranza(string[] datos_Consulta)
        {
            DataSet Dato_Almacenado = new DataSet();
            string consulta = "";
            try
            {
                if (datos_Consulta[0].Equals("*"))
                {
                    //cargamos todas las Facturas
                    //consulta = "Select distinct(Cab_NFactura),Det_CentroCostos from V_Detalle WHERE Cab_Estado='CA' and year(Det_FCreacion)=year(getdate()) and month(Det_FCreacion)=month(GETDATE())";
                    consulta = "Select distinct(Cabecera.Cab_NFactura),Detalle.Det_CentroCostos from Cabecera,Detalle WHERE Cabecera.Cab_Estado='CA' AND Cabecera.Cab_NFactura=Detalle.Cab_NFactura";
                
                }
                else if (datos_Consulta[0].Equals("Consulta_Varios"))
                {
                    //cargamos todas las Facturas
                    consulta = "Select distinct(Cab_NFactura),Det_CentroCostos from V_Detalle WHERE Cab_Estado='CA' and (Cab_RazonSocial LIKE '%" + datos_Consulta[1] + "%' OR RIGHT(Cab_NFactura,7) LIKE '%" + datos_Consulta[1] + "%') ";
                }
                else if (datos_Consulta[0].Equals("Consulta_Ciudad"))
                {
                    //cargamos todas las Facturas
                    consulta = "Select distinct(Cab_NFactura),Det_CentroCostos from V_Detalle WHERE Cab_Estado='CA' and Det_CentroCostos='" + datos_Consulta[1] + "' ";
                }
                else if (datos_Consulta[0].Equals("datos_Factura"))
                {
                    consulta = "select Det_Codigo,Det_Detalle,Det_Cantidad,det_VUnitario,Det_VNeto,Det_Iva,Det_TotalVenta,CAB_NFACTURA,Cab_RazonSocial,Det_Categoria,Cab_Valor,CONVERT(DATE,Cab_FEmision,103),det_ntrabajo from v_detalle where Cab_NFactura='" + datos_Consulta[1] + "' and Det_estado='A'";
                }
                else if (datos_Consulta[0].Equals("detalle_Comision"))
                {
                    consulta = "select Emp_Codigo AS '#', Emp_Nombre AS 'Nombre del Empleado' , Det_Detalle as 'Detalle', DetC_TipoComision as 'Tipo', DetC_porcentajeComision as 'Participacion',DetC_BaseComision as'Base', DetC_TotalComision as 'Total', Det_codigo from V_Comision where DetC_EstadoComision='A' and Cab_NFactura='" + datos_Consulta[1] + "' ";
                }

                else if (datos_Consulta[0].Equals("Comision_Factura"))
                {
                    //cargamos todos los datos datos
                    consulta = "select Emp_Codigo AS '#', Emp_Nombre AS 'Nombre del Empleado' , Det_Detalle as 'Detalle', DetC_TipoComision as 'Tipo', DetC_porcentajeComision as 'Participacion',DetC_BaseComision as'Base', DetC_TotalComision as 'Total', Det_codigo from V_Comision where DetC_EstadoComision='AA' ";
                }

                else if (datos_Consulta[0].Equals("Ciudad"))
                {
                    consulta = "select COUNT(DISTINCT(Cab_NFactura)),Det_CentroCostos from V_Detalle group by Det_CentroCostos";
                }
                ///seccion resumen de comisiones 

                else if (datos_Consulta[0].Equals("Comision_Todos"))
                {
                    consulta = "select Emp_Codigo AS '#', Emp_Nombre AS 'Nombre del Empleado' ,Cab_RazonSocial as 'Razon Social',Cab_NFactura AS 'Factura' ,Det_Detalle as 'Detalle', DetC_TipoComision as 'Tipo', DetC_porcentajeComision as 'Participacion',DetC_BaseComision as'Base', DetC_TotalComision as 'Total', Det_CentroCostos  from V_Comision where DetC_EstadoComision='A' and month(DetC_fechaCreacion)=MONTH(GETDATE()) and YEAR(DetC_fechaCreacion)=YEAR(GETDATE())   ";
                }

                else if (datos_Consulta[0].Equals("Comision_Empleado"))
                {
                    consulta = "select Emp_Codigo AS '#', Emp_Nombre AS 'Nombre del Empleado' ,Cab_RazonSocial as 'Razon Social',Cab_NFactura AS 'Factura' ,Det_Detalle as 'Detalle', DetC_TipoComision as 'Tipo', DetC_porcentajeComision as 'Participacion',DetC_BaseComision as'Base', DetC_TotalComision as 'Total', Det_CentroCostos from V_Comision where DetC_EstadoComision='A' and Emp_Nombre like '%" + datos_Consulta[1] + "%' and month(DetC_fechaCreacion)=MONTH(GETDATE()) and YEAR(DetC_fechaCreacion)=YEAR(GETDATE())  ";
                }
                else if (datos_Consulta[0].Equals("Comision_Sucursal"))
                {
                    consulta = "select Emp_Codigo AS '#', Emp_Nombre AS 'Nombre del Empleado' ,Cab_RazonSocial as 'Razon Social',Cab_NFactura AS 'Factura' ,Det_Detalle as 'Detalle', DetC_TipoComision as 'Tipo', DetC_porcentajeComision as 'Participacion',DetC_BaseComision as'Base', DetC_TotalComision as 'Total', Det_CentroCostos from V_Comision where DetC_EstadoComision='A' AND Det_CentroCostos='" + datos_Consulta[1] + "' and month(DetC_fechaCreacion)=MONTH(GETDATE()) and YEAR(DetC_fechaCreacion)=YEAR(GETDATE())   ";
                }
                

                /// fin seccion resumen de comisiones 

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




        public DataSet Comisiones_Asignadas(string[] datos_Consulta)
        {
            DataSet Dato_Almacenado = new DataSet();
            string consulta = "";
            try
            {
                if (datos_Consulta[0].Equals("*"))
                {
                    //cargamos todas las Facturas
                    consulta = "Select distinct(Cab_NFactura),Det_CentroCostos from V_DetalleP WHERE Cab_Estado='P' and year(DetC_fechaCreacion)=year(getdate()) and month(DetC_fechaCreacion)=month(GETDATE())";
                }
                else if (datos_Consulta[0].Equals("Consulta_Varios"))
                {
                    //cargamos todas las Facturas
                   // consulta = "Select distinct(Cab_NFactura),Det_CentroCostos from V_Detalle WHERE Cab_Estado='P' and (Cab_RazonSocial LIKE '%" + datos_Consulta[1] + "%' OR Cab_NFactura LIKE '%" + datos_Consulta[1] + "') and year(Det_FCreacion)=year(getdate()) and month(Det_FCreacion)=month(GETDATE())";
                    consulta = "Select distinct(Cab_NFactura),Det_CentroCostos from V_DetalleP WHERE Cab_Estado='P' and (Cab_RazonSocial LIKE '%" + datos_Consulta[1] + "%' OR Cab_NFactura LIKE '%" + datos_Consulta[1] + "') ";
                
                }
                else if (datos_Consulta[0].Equals("Consulta_Ciudad"))
                {
                    //cargamos todas las Facturas
                    consulta = "Select distinct(Cab_NFactura),Det_CentroCostos from V_DetalleP WHERE Cab_Estado='P' and Det_CentroCostos='" + datos_Consulta[1] + "' and year(DetC_fechaCreacion)=year(getdate()) and month(DetC_fechaCreacion)=month(GETDATE())";
                }
                else if (datos_Consulta[0].Equals("datos_Factura"))
                {
                    consulta = "select DISTINCT(Det_Codigo),Det_Detalle,Det_Cantidad,det_VUnitario,Det_VNeto,Det_Iva,Det_TotalVenta,CAB_NFACTURA,Cab_RazonSocial,Det_Categoria,Cab_Valor,CONVERT(DATE,Cab_FEmision,103), Det_NTrabajo from v_detalleP where Cab_NFactura='" + datos_Consulta[1] + "' and Det_estado='P'";
                }
                else if (datos_Consulta[0].Equals("detalle_Comision"))
                {
                    consulta = "select Emp_Codigo AS '#', Emp_Nombre AS 'Nombre del Empleado' , Det_Detalle as 'Detalle', DetC_TipoComision as 'Tipo', DetC_porcentajeComision as 'Participacion',DetC_BaseComision as'Base', DetC_TotalComision as 'Total',Det_codigo from V_Comision where DetC_EstadoComision='A' and Cab_NFactura='" + datos_Consulta[1] + "' ";
                }
                else if (datos_Consulta[0].Equals("Ciudad"))
                {
                    consulta = "select COUNT(DISTINCT(Cab_NFactura)),Det_CentroCostos from V_Detalle group by Det_CentroCostos";
                }
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

      //insertamos los datos en la tabla de comisiones


        public string Insertar_Comisiones(string Det_Codigo, string Cab_NFactura, string Emp_Codigo, string DetC_TipoComision, string DetC_porcentajeComision, string DetC_Observacion,string codigo_safi)
              {
                  string Respuesta;
                  try
                  {
                      using (ConexionSql = new SqlConnection(CadenaSql.String_Conexion()))
                      {
                          ComandoSql = new SqlCommand("exec P_Comisiones  '" + Det_Codigo + "','" + Cab_NFactura + "','" + "0" + "','" + DetC_TipoComision + "','" + DetC_porcentajeComision + "','" + DetC_Observacion + "','" + Emp_Codigo + "'", ConexionSql);
                          ConexionSql.Open();
                          Respuesta = Convert.ToString(ComandoSql.ExecuteScalar());
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




        public string Modificamos_EstadoMovilizacion()
        {
            string Respuesta;
            try
            {
                using (ConexionSql = new SqlConnection(CadenaSql.String_Conexion()))
                {
                    ComandoSql = new SqlCommand("update detalle set det_estado='P' WHERE (DET_CATEGORIA='MOVILIZACION TECNICOS PRECITROL' or DET_CATEGORIA='MOVILIZACION CONTRATADA') AND det_estado='A' AND MONTH(Det_FCreacion)=MONTH(GETDATE())", ConexionSql);
                    ConexionSql.Open();
                    Respuesta = Convert.ToString(ComandoSql.ExecuteScalar());
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


      //eliminar datos


        public string Eliminar_Comisiones(string Cab_NFactura, string Det_Codigo, string Emp_Codigo)
        {
            string Respuesta;
            try
            {
                using (ConexionSql = new SqlConnection(CadenaSql.String_Conexion()))
                {
                    ComandoSql = new SqlCommand("exec E_ComisionAsignada  '" + Cab_NFactura + "','" + Det_Codigo + "','" + Emp_Codigo + "'", ConexionSql);
                    ConexionSql.Open();
                    Respuesta = Convert.ToString(ComandoSql.ExecuteScalar());
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

      //Seccion de reporte de coimisiones 
        
      
      
      public DataSet Reporte_Comisiones(string[] datos_Consulta)
        {
            DataSet Dato_Almacenado = new DataSet();
            string consulta = "";
            try
            {
                if (datos_Consulta[0].Equals("*"))
                {
                    //cargamos todos los datos datos                                                DetC_fechaCreacion
                    consulta = "select * from V_ComisionU where emp_codigosafi !='PC' AND CONVERT(date,DetC_fechaCreacion,103) BETWEEN CONVERT(date,'" + datos_Consulta[1] + "',103) AND CONVERT(date,'" + datos_Consulta[2] + "',103)";
                }
     

                else if (datos_Consulta[0].Equals("Empleado"))
                {
                    //cargamos todos los datos datos
                    consulta = "select * from V_ComisionU where emp_codigosafi !='PC' AND CONVERT(date,DetC_fechaCreacion,103) BETWEEN CONVERT(date,'" + datos_Consulta[1] + "',103) AND CONVERT(date,'" + datos_Consulta[2] + "',103) and Emp_CodigoSafi='" + datos_Consulta[3] + "' ";
                }
                else if (datos_Consulta[0].Equals("Ciudad"))
                {
                    //cargamos todos los datos datos
                    consulta = "select * from V_ComisionU where emp_codigosafi !='PC' AND CONVERT(date,DetC_fechaCreacion,103) BETWEEN CONVERT(date,'" + datos_Consulta[1] + "',103) AND CONVERT(date,'" + datos_Consulta[2] + "',103) and Emp_Ciudad='" + datos_Consulta[3] + "' ";
                }

                else if (datos_Consulta[0].Equals("Comision global"))
                {
                    //cargamos todos los datos datos
                    Comision_gerencia();
                    consulta = "select * from V_ComisionU where   CONVERT(date,DetC_fechaCreacion,103) BETWEEN CONVERT(date,'" + datos_Consulta[1] + "',103) AND CONVERT(date,'" + datos_Consulta[2] + "',103)";
                }
                else if (datos_Consulta[0].Equals("Comision_gerenciav"))
                {
                    //cargamos todos los datos datos
                    consulta = "select Emp_Nombre,Emp_TotalMOUIO * (SELECT TOP 1 sum(Det_VNeto) from Detalle where Det_CentroCostos='QUITO'  AND Det_Categoria='MANO DE OBRA SERVICIO TECNICO PROPIO' AND MONTH(Det_FCreacion)=MONTH(convert(date,'" + datos_Consulta[1] + "',103)) AND  YEAR(Det_FCreacion)=YEAR(convert(date,'" + datos_Consulta[1] + "',103))   group by Det_CentroCostos,Det_Categoria) AS 'MO_QUITO', "+
" CASE WHEN Emp_TotalMOUIO =0 THEN 0 ELSE (SELECT TOP 1 sum(Det_VNeto) from Detalle where Det_CentroCostos='QUITO'  AND Det_Categoria='MANO DE OBRA SERVICIO TECNICO PROPIO' AND MONTH(Det_FCreacion)=MONTH(convert(date,'" + datos_Consulta[1] + "',103)) AND  YEAR(Det_FCreacion)=YEAR(convert(date,'" + datos_Consulta[1] + "',103))   group by Det_CentroCostos,Det_Categoria) END AS 'MO_QUITOBASE',"+
" Emp_TotalRepuestosUIO * (SELECT TOP 1 sum(Det_VNeto) from Detalle where Det_CentroCostos='QUITO'  AND Det_Categoria='REPUESTOS' AND MONTH(Det_FCreacion)=MONTH(convert(date,'" + datos_Consulta[1] + "',103)) AND  YEAR(Det_FCreacion)=YEAR(convert(date,'" + datos_Consulta[1] + "',103))   group by Det_CentroCostos,Det_Categoria) AS 'REPUESTOS_QUITO',"+
" CASE WHEN Emp_TotalRepuestosUIO =0 THEN 0 ELSE (SELECT TOP 1 sum(Det_VNeto) from Detalle where Det_CentroCostos='QUITO'  AND Det_Categoria='REPUESTOS' AND MONTH(Det_FCreacion)=MONTH(convert(date,'" + datos_Consulta[1] + "',103)) AND  YEAR(Det_FCreacion)=YEAR(convert(date,'" + datos_Consulta[1] + "',103))   group by Det_CentroCostos,Det_Categoria) END AS 'REPUESTOS_QUITOBASE',"+
" Emp_TotalSWUIO * (SELECT TOP 1 sum(Det_VNeto) from Detalle where Det_CentroCostos='QUITO'  AND Det_Categoria='PROGRAMACION' AND MONTH(Det_FCreacion)=MONTH(convert(date,'" + datos_Consulta[1] + "',103)) AND  YEAR(Det_FCreacion)=YEAR(convert(date,'" + datos_Consulta[1] + "',103))   group by Det_CentroCostos,Det_Categoria) AS 'Software_QUITO',"+
" CASE WHEN Emp_TotalSWUIO =0 THEN 0 ELSE (SELECT TOP 1 sum(Det_VNeto) from Detalle where Det_CentroCostos='QUITO'  AND Det_Categoria='PROGRAMACION' AND MONTH(Det_FCreacion)=MONTH(convert(date,'" + datos_Consulta[1] + "',103)) AND  YEAR(Det_FCreacion)=YEAR(convert(date,'" + datos_Consulta[1] + "',103))   group by Det_CentroCostos,Det_Categoria) END AS 'Software_QUITOBASE',"+
" Emp_TotalMetrologiaUIO * (SELECT TOP 1 sum(Det_VNeto) from Detalle where Det_CentroCostos='QUITO'  AND Det_Categoria='METROLOGÍA' AND MONTH(Det_FCreacion)=MONTH(convert(date,'" + datos_Consulta[1] + "',103)) AND  YEAR(Det_FCreacion)=YEAR(convert(date,'" + datos_Consulta[1] + "',103))   group by Det_CentroCostos,Det_Categoria) AS 'Metrologia_QUITO',"+
" CASE WHEN Emp_TotalMetrologiaUIO =0 THEN 0 ELSE (SELECT TOP 1 sum(Det_VNeto) from Detalle where Det_CentroCostos='QUITO'  AND Det_Categoria='METROLOGÍA' AND MONTH(Det_FCreacion)=MONTH(convert(date,'" + datos_Consulta[1] + "',103)) AND  YEAR(Det_FCreacion)=YEAR(convert(date,'" + datos_Consulta[1] + "',103))   group by Det_CentroCostos,Det_Categoria) END AS 'Metrologia_QUITOBASE'"+
" ,Emp_TotalMOGYE * (SELECT TOP 1 sum(Det_VNeto) from Detalle where Det_CentroCostos='GUAYAQUIL'  AND Det_Categoria='MANO DE OBRA SERVICIO TECNICO PROPIO' AND MONTH(Det_FCreacion)=MONTH(convert(date,'" + datos_Consulta[1] + "',103)) AND  YEAR(Det_FCreacion)=YEAR(convert(date,'" + datos_Consulta[1] + "',103))   group by Det_CentroCostos,Det_Categoria) AS 'MO_GUAYAQUIL',"+
" CASE WHEN Emp_TotalMOGYE =0 THEN 0 ELSE (SELECT TOP 1 sum(Det_VNeto) from Detalle where Det_CentroCostos='GUAYAQUIL'  AND Det_Categoria='MANO DE OBRA SERVICIO TECNICO PROPIO' AND MONTH(Det_FCreacion)=MONTH(convert(date,'" + datos_Consulta[1] + "',103)) AND  YEAR(Det_FCreacion)=YEAR(convert(date,'" + datos_Consulta[1] + "',103))   group by Det_CentroCostos,Det_Categoria) END AS 'MO_GUAYAQUILBASE',"+
" Emp_TotalRepuestosGYE * (SELECT TOP 1 sum(Det_VNeto) from Detalle where Det_CentroCostos='GUAYAQUIL'  AND Det_Categoria='REPUESTOS' AND MONTH(Det_FCreacion)=MONTH(convert(date,'" + datos_Consulta[1] + "',103)) AND  YEAR(Det_FCreacion)=YEAR(convert(date,'" + datos_Consulta[1] + "',103))   group by Det_CentroCostos,Det_Categoria) AS 'REPUESTOS_GUAYAQUIL',"+
" CASE WHEN Emp_TotalRepuestosGYE =0 THEN 0 ELSE (SELECT TOP 1 sum(Det_VNeto) from Detalle where Det_CentroCostos='GUAYAQUIL'  AND Det_Categoria='REPUESTOS' AND MONTH(Det_FCreacion)=MONTH(convert(date,'" + datos_Consulta[1] + "',103)) AND  YEAR(Det_FCreacion)=YEAR(convert(date,'" + datos_Consulta[1] + "',103))   group by Det_CentroCostos,Det_Categoria) END AS 'REPUESTOS_GUAYAQUILBASE',"+
" CASE WHEN Emp_TotalSWGYE * (SELECT TOP 1 sum(Det_VNeto) from Detalle where Det_CentroCostos='GUAYAQUIL'  AND Det_Categoria='PROGRAMACION' AND MONTH(Det_FCreacion)=MONTH(convert(date,'" + datos_Consulta[1] + "',103)) AND  YEAR(Det_FCreacion)=YEAR(convert(date,'" + datos_Consulta[1] + "',103))   group by Det_CentroCostos,Det_Categoria) IS NULL THEN 0 ELSE"+
" Emp_TotalSWGYE * (SELECT TOP 1 sum(Det_VNeto) from Detalle where Det_CentroCostos='GUAYAQUIL'  AND Det_Categoria='PROGRAMACION' AND MONTH(Det_FCreacion)=MONTH(convert(date,'" + datos_Consulta[1] + "',103)) AND  YEAR(Det_FCreacion)=YEAR(convert(date,'" + datos_Consulta[1] + "',103))   group by Det_CentroCostos,Det_Categoria)END AS 'Software_GUAYAQUIL',"+
" CASE WHEN (SELECT TOP 1 sum(Det_VNeto) from Detalle where Det_CentroCostos='GUAYAQUIL'  AND Det_Categoria='PROGRAMACION' AND MONTH(Det_FCreacion)=MONTH(convert(date,'" + datos_Consulta[1] + "',103)) AND  YEAR(Det_FCreacion)=YEAR(convert(date,'" + datos_Consulta[1] + "',103))   group by Det_CentroCostos,Det_Categoria)   IS NULL THEN 0 ELSE (SELECT TOP 1 sum(Det_VNeto) from Detalle where Det_CentroCostos='GUAYAQUIL'  AND Det_Categoria='PROGRAMACION' AND MONTH(Det_FCreacion)=MONTH(convert(date,'" + datos_Consulta[1] + "',103)) AND  YEAR(Det_FCreacion)=YEAR(convert(date,'" + datos_Consulta[1] + "',103))   group by Det_CentroCostos,Det_Categoria) END AS 'Software_GUAYAQUILBASE',"+
" Emp_TotalMetrologiaGYE * (SELECT TOP 1 sum(Det_VNeto) from Detalle where Det_CentroCostos='GUAYAQUIL'  AND Det_Categoria='METROLOGÍA' AND MONTH(Det_FCreacion)=MONTH(convert(date,'" + datos_Consulta[1] + "',103)) AND  YEAR(Det_FCreacion)=YEAR(convert(date,'" + datos_Consulta[1] + "',103))   group by Det_CentroCostos,Det_Categoria) AS 'Metrologia_GUAYAQUIL',"+
" CASE WHEN Emp_TotalMetrologiaGYE =0 THEN 0 ELSE (SELECT TOP 1 sum(Det_VNeto) from Detalle where Det_CentroCostos='GUAYAQUIL'  AND Det_Categoria='METROLOGÍA' AND MONTH(Det_FCreacion)=MONTH(convert(date,'" + datos_Consulta[1] + "',103)) AND  YEAR(Det_FCreacion)=YEAR(convert(date,'" + datos_Consulta[1] + "',103))  group by Det_CentroCostos,Det_Categoria) END AS 'Metrologia_GUAYAQUILBASE'"+
" ,Emp_TotalMOMTA * (SELECT TOP 1 sum(Det_VNeto) from Detalle where Det_CentroCostos='MANTA'  AND Det_Categoria='MANO DE OBRA SERVICIO TECNICO PROPIO' AND MONTH(Det_FCreacion)=MONTH(convert(date,'" + datos_Consulta[1] + "',103)) AND  YEAR(Det_FCreacion)=YEAR(convert(date,'" + datos_Consulta[1] + "',103))   group by Det_CentroCostos,Det_Categoria) AS 'MO_MANTA',"+
" CASE WHEN Emp_TotalMOMTA =0 THEN 0 ELSE (SELECT TOP 1 sum(Det_VNeto) from Detalle where Det_CentroCostos='MANTA'  AND Det_Categoria='MANO DE OBRA SERVICIO TECNICO PROPIO' AND MONTH(Det_FCreacion)=MONTH(convert(date,'" + datos_Consulta[1] + "',103)) AND  YEAR(Det_FCreacion)=YEAR(convert(date,'" + datos_Consulta[1] + "',103))  group by Det_CentroCostos,Det_Categoria) END AS 'MO_MANTABASE',"+
" CASE WHEN (Emp_TotalRepuestosMTA * (SELECT TOP 1 sum(Det_VNeto) from Detalle where Det_CentroCostos='MANTA'  AND Det_Categoria='REPUESTOS' AND MONTH(Det_FCreacion)=MONTH(convert(date,'" + datos_Consulta[1] + "',103)) AND  YEAR(Det_FCreacion)=YEAR(convert(date,'" + datos_Consulta[1] + "',103))  group by Det_CentroCostos,Det_Categoria)) IS NULL  THEN 0     ELSE Emp_TotalRepuestosMTA * (SELECT TOP 1 sum(Det_VNeto) from Detalle where Det_CentroCostos='MANTA'  AND Det_Categoria='REPUESTOS' AND MONTH(Det_FCreacion)=MONTH(convert(date,'" + datos_Consulta[1] + "',103)) AND  YEAR(Det_FCreacion)=YEAR(convert(date,'" + datos_Consulta[1] + "',103))   group by Det_CentroCostos,Det_Categoria) END AS 'REPUESTOS_MANTA',"+
" CASE WHEN (SELECT TOP 1 sum(Det_VNeto) from Detalle where Det_CentroCostos='MANTA'  AND Det_Categoria='REPUESTOS' AND MONTH(Det_FCreacion)=MONTH(convert(date,'" + datos_Consulta[1] + "',103)) AND  YEAR(Det_FCreacion)=YEAR(convert(date,'" + datos_Consulta[1] + "',103))  group by Det_CentroCostos,Det_Categoria) IS NULL THEN 0"+ 
" ELSE (SELECT TOP 1 sum(Det_VNeto) from Detalle where Det_CentroCostos='MANTA'  AND Det_Categoria='REPUESTOS' AND MONTH(Det_FCreacion)=MONTH(convert(date,'" + datos_Consulta[1] + "',103)) AND  YEAR(Det_FCreacion)=YEAR(convert(date,'" + datos_Consulta[1] + "',103))   group by Det_CentroCostos,Det_Categoria) END AS 'REPUESTOS_MANTABASE',"+
" Emp_TotalMetrologiaMTA * (SELECT TOP 1 sum(Det_VNeto) from Detalle where Det_CentroCostos='MANTA'  AND Det_Categoria='METROLOGÍA' AND MONTH(Det_FCreacion)=MONTH(convert(date,'" + datos_Consulta[1] + "',103)) AND  YEAR(Det_FCreacion)=YEAR(convert(date,'" + datos_Consulta[1] + "',103))   group by Det_CentroCostos,Det_Categoria) AS 'Metrologia_MANTA',"+
" CASE WHEN Emp_TotalMetrologiaMTA =0 THEN 0 ELSE (SELECT TOP 1 sum(Det_VNeto) from Detalle where Det_CentroCostos='MANTA'  AND Det_Categoria='METROLOGÍA' AND MONTH(Det_FCreacion)=MONTH(convert(date,'" + datos_Consulta[1] + "',103)) AND  YEAR(Det_FCreacion)=YEAR(convert(date,'" + datos_Consulta[1] + "',103))   group by Det_CentroCostos,Det_Categoria) END AS 'Metrologia_MANTABASE',"+
" Emp_Materiales * (SELECT TOP 1 sum(Det_VNeto) from Detalle where Det_CentroCostos='MANTA'  AND Det_Categoria='MATERIALES' AND MONTH(Det_FCreacion)=MONTH(convert(date,'" + datos_Consulta[1] + "',103)) AND  YEAR(Det_FCreacion)=YEAR(convert(date,'" + datos_Consulta[1] + "',103))   group by Det_CentroCostos,Det_Categoria) AS 'Material_MANTA',"+
" CASE WHEN Emp_Materiales =0 THEN 0 ELSE (SELECT TOP 1 sum(Det_VNeto) from Detalle where Det_CentroCostos='MANTA'  AND Det_Categoria='MATERIALES' AND MONTH(Det_FCreacion)=MONTH(convert(date,'" + datos_Consulta[1] + "',103)) AND  YEAR(Det_FCreacion)=YEAR(convert(date,'" + datos_Consulta[1] + "',103))   group by Det_CentroCostos,Det_Categoria) END AS 'Material_MANTABASE',"+
" Emp_Materiales * (SELECT TOP 1 sum(Det_VNeto) from Detalle where Det_CentroCostos='QUITO'  AND Det_Categoria='MATERIALES' AND MONTH(Det_FCreacion)=MONTH(convert(date,'" + datos_Consulta[1] + "',103)) AND  YEAR(Det_FCreacion)=YEAR(convert(date,'" + datos_Consulta[1] + "',103))   group by Det_CentroCostos,Det_Categoria) AS 'Material_QUITO',"+
" CASE WHEN Emp_Materiales =0 THEN 0 ELSE (SELECT TOP 1 sum(Det_VNeto) from Detalle where Det_CentroCostos='QUITO'  AND Det_Categoria='MATERIALES' AND MONTH(Det_FCreacion)=MONTH(convert(date,'" + datos_Consulta[1] + "',103)) AND  YEAR(Det_FCreacion)=YEAR(convert(date,'" + datos_Consulta[1] + "',103))   group by Det_CentroCostos,Det_Categoria) END AS 'Material_QUITOBASE',"+
" Emp_Materiales * (SELECT TOP 1 sum(Det_VNeto) from Detalle where Det_CentroCostos='GUAYAQUIL'  AND Det_Categoria='MATERIALES' AND MONTH(Det_FCreacion)=MONTH(convert(date,'" + datos_Consulta[1] + "',103)) AND  YEAR(Det_FCreacion)=YEAR(convert(date,'" + datos_Consulta[1] + "',103))   group by Det_CentroCostos,Det_Categoria) AS 'Material_GYE',"+
" CASE WHEN Emp_Materiales =0 THEN 0 ELSE (SELECT TOP 1 sum(Det_VNeto) from Detalle where Det_CentroCostos='GUAYAQUIL'  AND Det_Categoria='MATERIALES' AND MONTH(Det_FCreacion)=MONTH(convert(date,'" + datos_Consulta[1] + "',103)) AND  YEAR(Det_FCreacion)=YEAR(convert(date,'" + datos_Consulta[1] + "',103))   group by Det_CentroCostos,Det_Categoria) END AS 'Material_GYEBASE',"+
" Emp_ManoContratada * (SELECT TOP 1 sum(Det_VNeto) from Detalle where Det_CentroCostos='MANTA'  AND Det_Categoria='MANO DE OBRA CONTRATADA' AND MONTH(Det_FCreacion)=MONTH(convert(date,'" + datos_Consulta[1] + "',103)) AND  YEAR(Det_FCreacion)=YEAR(convert(date,'" + datos_Consulta[1] + "',103))   group by Det_CentroCostos,Det_Categoria) AS 'MCONTRATADA_MANTA',"+
" CASE WHEN Emp_ManoContratada =0 THEN 0 ELSE (SELECT TOP 1 sum(Det_VNeto) from Detalle where Det_CentroCostos='MANTA'  AND Det_Categoria='MANO DE OBRA CONTRATADA' AND MONTH(Det_FCreacion)=MONTH(convert(date,'" + datos_Consulta[1] + "',103)) AND  YEAR(Det_FCreacion)=YEAR(convert(date,'" + datos_Consulta[1] + "',103))   group by Det_CentroCostos,Det_Categoria) END AS 'MCONTRATADA_MANTABASE',"+
" Emp_ManoContratada * (SELECT TOP 1 sum(Det_VNeto) from Detalle where Det_CentroCostos='QUITO'  AND Det_Categoria='MANO DE OBRA CONTRATADA' AND MONTH(Det_FCreacion)=MONTH(convert(date,'" + datos_Consulta[1] + "',103)) AND  YEAR(Det_FCreacion)=YEAR(convert(date,'" + datos_Consulta[1] + "',103))   group by Det_CentroCostos,Det_Categoria) AS 'MCONTRATADA_QUITO',"+
" CASE WHEN Emp_ManoContratada =0 THEN 0 ELSE (SELECT TOP 1 sum(Det_VNeto) from Detalle where Det_CentroCostos='QUITO'  AND Det_Categoria='MANO DE OBRA CONTRATADA' AND MONTH(Det_FCreacion)=MONTH(convert(date,'" + datos_Consulta[1] + "',103)) AND  YEAR(Det_FCreacion)=YEAR(convert(date,'" + datos_Consulta[1] + "',103))   group by Det_CentroCostos,Det_Categoria) END AS 'MCONTRATADA_QUITOBASE',"+
" Emp_ManoContratada * (SELECT TOP 1 sum(Det_VNeto) from Detalle where Det_CentroCostos='GUAYAQUIL'  AND Det_Categoria='MANO DE OBRA CONTRATADA' AND MONTH(Det_FCreacion)=MONTH(convert(date,'" + datos_Consulta[1] + "',103)) AND  YEAR(Det_FCreacion)=YEAR(convert(date,'" + datos_Consulta[1] + "',103))   group by Det_CentroCostos,Det_Categoria) AS 'MCONTRATADAbase_gye',"+
" CASE WHEN Emp_ManoContratada =0 THEN 0 ELSE (SELECT TOP 1 sum(Det_VNeto) from Detalle where Det_CentroCostos='GUAYAQUIL'  AND Det_Categoria='MANO DE OBRA CONTRATADA' AND MONTH(Det_FCreacion)=MONTH(convert(date,'" + datos_Consulta[1] + "',103)) AND  YEAR(Det_FCreacion)=YEAR(convert(date,'" + datos_Consulta[1] + "',103))   group by Det_CentroCostos,Det_Categoria) END AS 'MCONTRATADA_gye'"+
" from Empleados"+
" WHERE        (Emp_TotalMOUIO <> 0) OR"+
"                         (Emp_TotalMetrologiaUIO <> 0) OR"+
"                         (Emp_TotalRepuestosUIO <> 0) OR"+
"                         (Emp_TotalSWUIO <> 0) OR"+
"                         (Emp_TotalMOGYE <> 0) OR"+
"                        (Emp_TotalMetrologiaGYE <> 0) OR"+
"                         (Emp_TotalRepuestosGYE <> 0) OR"+
"                         (Emp_TotalSWGYE <> 0) OR"+
"                         (Emp_TotalMOMTA <> 0) OR"+
"                         (Emp_TotalMetrologiaMTA <> 0) OR"+
"                        (Emp_TotalRepuestosMTA <> 0)";
                }


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

        //Seccion de reporte de coimisiones 
        public DataSet Reporte_ComisionesGobales(string[] datos_Consulta)
        {
            DataSet Dato_Almacenado = new DataSet();
            string consulta = "";
            try
            {
                if (datos_Consulta[0].Equals("*"))
                {
                    //cargamos todos los datos datosDetC_fechaCreacion
                    consulta = "select * from V_ComisionU where emp_codigosafi !='PC' AND CONVERT(date,DetC_fechaCreacion,103) BETWEEN CONVERT(date,'" + datos_Consulta[1] + "',103) AND CONVERT(date,'" + datos_Consulta[2] + "',103)";
                }
            

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
      ////----proceso para insrtar comisiones por factura



        public string Insertar_ComisionesFactura(string Cab_NFactura, string Emp_Codigo, string DetC_TipoComision, string DetC_porcentajeComision, string Base_Comision, string Valor_Comsion,string DetC_Observacion,string pago)
        {
     string Respuesta;
            try
            {
                using (ConexionSql = new SqlConnection(CadenaSql.String_Conexion()))
                {
                    ComandoSql = new SqlCommand("exec P_ComisionXFactura  '" + Cab_NFactura + "','" + Emp_Codigo + "','" + DetC_TipoComision + "','" + DetC_porcentajeComision + "','0','" + Base_Comision + "','" + Valor_Comsion + "','" + DetC_Observacion + "','"+pago+"'", ConexionSql);
                    ConexionSql.Open();
                    Respuesta = Convert.ToString(ComandoSql.ExecuteScalar());
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



        public string Comision_gerencia()
        {
            string Respuesta;
            try
            {
                using (ConexionSql = new SqlConnection(CadenaSql.String_Conexion()))
                {
                    ComandoSql = new SqlCommand("exec P_ComisionGerencia", ConexionSql);
                    ConexionSql.Open();
                    Respuesta = Convert.ToString(ComandoSql.ExecuteScalar());
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

      //****************************************************


    }
}
