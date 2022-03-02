using DatosComisiones;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegociosComisiones
{
  public  class Negocios_Comision
    {
        Datos_Comisiones Comision = new Datos_Comisiones();
        public DataSet Cobranza(string[] datos_Consulta)
        {
            return Comision.Cobranza(datos_Consulta);
        }

        public DataSet Comisiones_Asignadas(string[] datos_Consulta)
        {
            return Comision.Comisiones_Asignadas(datos_Consulta);
        }


        public string Insertar_Comisiones(string Det_Codigo, string Cab_NFactura, string Emp_Codigo, string DetC_TipoComision, string DetC_porcentajeComision, string DetC_Observacion,string Codigo_Safi)
        {
            return Comision.Insertar_Comisiones(Det_Codigo, Cab_NFactura, Emp_Codigo, DetC_TipoComision, DetC_porcentajeComision, DetC_Observacion, Codigo_Safi);
        }

         public string Modificamos_EstadoMovilizacion()
        {
            return Comision.Modificamos_EstadoMovilizacion();
        }

        public string Eliminar_Comisiones(string Cab_NFactura, string Det_Codigo, string Emp_Codigo)
        {
            return Comision.Eliminar_Comisiones(Cab_NFactura, Det_Codigo, Emp_Codigo);
        }

        public DataSet Reporte_Comisiones(string[] datos_Consulta)
        {
            return Comision.Reporte_Comisiones(datos_Consulta);

        }
      ////COMISION POR FACTURA 
        public string Insertar_ComisionesFactura(string Cab_NFactura, string Emp_Codigo, string DetC_TipoComision, string DetC_porcentajeComision, string Base_Comision, string Valor_Comsion, string DetC_Observacion,string pago)
        {
           
            return Comision.Insertar_ComisionesFactura(  Cab_NFactura,  Emp_Codigo,  DetC_TipoComision,  DetC_porcentajeComision,  Base_Comision,  Valor_Comsion, DetC_Observacion,pago);
        }

    }
}
