using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatosComisiones;
using System.Data;
namespace NegociosComisiones
{
  public  class NegociosComision_V2
    {
      Comision_V2 comision = new Comision_V2();
      public DataSet Cargar_ComisionesEmpleados()//Cargamos los datos de la tabla Tipo_Comision
      {

          return comision.Cargar_ComisionesEmpleados();
      }
    }
}
