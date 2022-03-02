using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatosComisiones;
using System.Data;
namespace NegociosComisiones
{
   public class Negocios_Excel
    {
       Datos_Excel excel = new Datos_Excel();


       public DataSet Cargar_InformacionExcel()//Cargamos los datos de la tabla Tipo_Comision
        {

            return excel.Cargar_InformacionExcel();
        }
    }
}
