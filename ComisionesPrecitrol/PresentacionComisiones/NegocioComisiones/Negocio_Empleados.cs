using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatosComisiones;
using System.Data;
namespace NegociosComisiones
{
   public class Negocio_Empleados
    {
       Datos_Empleados Empleados = new Datos_Empleados();


       public DataSet Cargar_EmpleadosComisiones()//Cargamos los datos de la tabla Tipo_Comision
       {

           return Empleados.Cargar_EmpleadosComisiones();
       }
       
       public int Codigo_Empleado()
       {

           return Empleados.Codigo_Empleado();
       }

       public int Insertar_Empleados(String Emp_Codigo, String Emp_Nombre, String Emp_Ciudad, String Emp_Sueldo, String Emp_ComisionFija, String Emp_ComisionManoObra
                                               , String Emp_ComisionRepuesto, String Emp_Software, String Emp_ComisionMetrologia, String Emp_TotalMOUIO
                                               , String Emp_TotalMetrologiaUIO, String Emp_TotalRepuestosUIO, String Emp_TotalSWUIO, String Emp_TotalMOGYE, String Emp_TotalMetrologiaGYE
                                               , String Emp_TotalRepuestosGYE, String Emp_TotalSWGYE, String Emp_TotalMOMTA, String Emp_TotalMetrologiaMTA, String Emp_TotalRepuestosMTA
                                               , String Emp_Estado, string codigo_safi, string Correo)
       {

           return Empleados.Insertar_Empleados(Emp_Codigo,  Emp_Nombre,  Emp_Ciudad,  Emp_Sueldo,  Emp_ComisionFija,  Emp_ComisionManoObra
                                               ,  Emp_ComisionRepuesto,  Emp_Software,  Emp_ComisionMetrologia,  Emp_TotalMOUIO
                                               ,  Emp_TotalMetrologiaUIO,  Emp_TotalRepuestosUIO,  Emp_TotalSWUIO,  Emp_TotalMOGYE,  Emp_TotalMetrologiaGYE
                                               ,  Emp_TotalRepuestosGYE,  Emp_TotalSWGYE,  Emp_TotalMOMTA,  Emp_TotalMetrologiaMTA,  Emp_TotalRepuestosMTA
                                               ,  Emp_Estado,codigo_safi,Correo );

       }
    }
}
