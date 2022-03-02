using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DatosComisiones;
namespace NegociosComisiones
{
   public class Negocios_Usuarios
    {
       Datos_Usuarios Usuario = new Datos_Usuarios();
       public bool  Consulta_Usuarios(string Usu, string pass)
       {
           return Usuario.Consulta_Usuarios(Usu,pass);
       }

       public string Obtener_Codigo()
       {
         return Usuario.Obtener_Codigo();
       }


       public string Guardar_Usuario(string Usu_Codigo, string Usu_Rol, string Usu_Usuario, string Usu_Pasword)
       {
           return Usuario.Guardar_Usuario( Usu_Codigo,  Usu_Rol,  Usu_Usuario,  Usu_Pasword);
       }

       public DataSet Usuarios_Registrados()//Cargamos los datos de la tabla Tipo_Comision
       {
           
           return Usuario.Usuarios_Registrados();
       }



    }
}
