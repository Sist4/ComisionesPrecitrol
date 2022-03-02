using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatosComisiones;
namespace NegociosComisiones
{
   public class Negocios_Porcentaje
    {
        Datos_Porcentaje participacion = new Datos_Porcentaje();

        public int Insertas_Porcentaje(String Par_NFactura, String Emp_Codigo, String Par_Fecha, String Par_Categoria, String Par_Porcentaje, String Par_Detalle
                                       , String Par_VNeto, String Par_CentroCostos, String Par_RazonSocial
                                      )
        {
            
            return participacion.Insertas_Porcentaje(Par_NFactura, Emp_Codigo, Par_Fecha, Par_Categoria, Par_Porcentaje, Par_Detalle
                                       , Par_VNeto, Par_CentroCostos, Par_RazonSocial);
        }




        public DataSet Porcentajes_Participacion(string[] datos_Consulta)
        {
            
            return participacion.Porcentajes_Participacion(datos_Consulta);
        }

    }
}
