using DatosComisiones;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegociosComisiones
{
   public  class Negocios_DetalleM
    {
        Datos_DetalleM Detalle = new Datos_DetalleM();

        public int Insertas_Detalle(string Det_Codigo, string Cab_NFactura, string Det_NTrabajo, string Det_Detalle, string Det_Categoria, string Det_Comentario, string Det_Cantidad, string Det_VUnitario, string Det_VNeto, string Det_Iva, string Det_TotalVenta, string C_costosv, string DATOS_ADICIONALES)
        {
            return Detalle.Insertar_Detalle(Det_Codigo, Cab_NFactura, Det_NTrabajo, Det_Detalle, Det_Categoria, Det_Comentario, Det_Cantidad, Det_VUnitario, Det_VNeto, Det_Iva, Det_TotalVenta, C_costosv, DATOS_ADICIONALES);
        }

        public DataSet Reporte_Cobranza(string Cobranza_desde, string Cobranza_hasta)
        {
            return Detalle.Reporte_Cobranza(Cobranza_desde, Cobranza_hasta);
        }
    }
}
