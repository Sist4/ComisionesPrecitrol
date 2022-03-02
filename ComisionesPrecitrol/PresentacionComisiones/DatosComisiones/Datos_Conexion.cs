using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosComisiones
{
   public class Datos_Conexion
    {
       public string String_Conexion()
       {
         return @"data source= 192.168.9.200\SRVMETROLOGIA; initial catalog = ComisionesPrecitrolV2; user id = sa; password = Sistemas123*";
          //return "data source = SISTEMAS\\SQL2014; initial catalog = ComisionesPrecitrolV2; user id = sa; password = Sistemas123";

          //return @"data source = 192.168.9.223\METROLOGIA; initial catalog = ComisionesPrecitrolV2; user id = sa; password = Sistemas123*";
          // return @"data source = 192.168.9.223\METROLOGIA; initial catalog = BaseDatos; user id = Usuario; password = Contraseña";

        }
    }
}
