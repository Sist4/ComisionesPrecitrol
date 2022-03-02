using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DatosComisiones
{
   public class Datos_Usuarios
    {
        SqlConnection ConexionSql = null;
        SqlCommand ComandoSql = null;
        String query = null;
        SqlDataReader LectorDatos = null;
        SqlDataAdapter AdaptadorSql = null;
        DataSet DatoAlmacenado = null;
        private Datos_Conexion CadenaSql = new Datos_Conexion();
        public bool  Consulta_Usuarios(string Usu,string pass)//Cargamos los datos de la tabla Tipo_Comision
        {
            DataSet Dato_Almacenado = new DataSet();
            string consulta;
            try
            {
                consulta = "select * from Usuarios where Usu_Estado='A' AND Usu_Usuario='" + Usu + "' AND Usu_Pasword='" + pass + "'";
                using (ConexionSql = new SqlConnection(CadenaSql.String_Conexion()))
                {
                    ConexionSql.Open();
                    SqlCommand Comando_Sql = new SqlCommand(consulta, ConexionSql);
                    int count = Convert.ToInt32(Comando_Sql.ExecuteScalar());
                    ConexionSql.Close();
                    if (count == 0)
                        return false;
                    else
                        return true;
                }
            }
            finally
            {
                if (ConexionSql != null && ConexionSql.State != ConnectionState.Closed)
                {
                    ConexionSql.Close();
                }
            }
        }

        //Obtenemos el valor parar el codigo
        public string Obtener_Codigo()
        {
          
            string consulta;
            try
            {
                consulta = "select max(usu_codigo +1) from Usuarios";
                using (ConexionSql = new SqlConnection(CadenaSql.String_Conexion()))
                {
                    ConexionSql.Open();
                    SqlCommand Comando_Sql = new SqlCommand(consulta, ConexionSql);
                    consulta = Convert.ToString(Comando_Sql.ExecuteScalar());
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
            return consulta;

        }

        public string Guardar_Usuario(string Usu_Codigo,string Usu_Rol,string Usu_Usuario,string Usu_Pasword)
        {

            string consulta;
            try
            {
                consulta = "execute P_Usuario '" + Usu_Codigo + "','" + Usu_Rol + "','" + Usu_Usuario + "','" + Usu_Pasword + "'";
                using (ConexionSql = new SqlConnection(CadenaSql.String_Conexion()))
                {
                    ConexionSql.Open();
                    SqlCommand Comando_Sql = new SqlCommand(consulta, ConexionSql);
                    consulta = Convert.ToString(Comando_Sql.ExecuteScalar());
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
            return consulta;

        }


        public DataSet Usuarios_Registrados()//Cargamos los datos de la tabla Tipo_Comision
        {
            DataSet Dato_Almacenado = new DataSet();
            string consulta;
            try
            {
                consulta = "SELECT Usu_Codigo as '#' ,Usu_Usuario as 'USUARIOS',Usu_Pasword AS 'CONTRASEÑA',Usu_Rol AS 'ROL',Usu_Estado AS 'ESTADO' FROM Usuarios where Usu_Estado='A'";
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
