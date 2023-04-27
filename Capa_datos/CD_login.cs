using Capa_entidad;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Capa_datos
{
    public class CD_login
    {
        CD_conexion conexion = new CD_conexion();
        SqlCommand comando = new SqlCommand();
        SqlDataReader leer;

        public List<string> lista(Ce_login login)  //creamos un metodo tipo lista que recibe el modelo de la capa entidad y le da como nombre login
        {
            comando.Parameters.Clear();
            List<string> result = new List<string>();  //instanciamos la clase lista
            comando.Connection = conexion.Abrir_conexion();
            comando.CommandText = "Buscarvendedores";  //indicamos el nombre del procedimiento
            comando.CommandType = CommandType.StoredProcedure;  //el tipo de consulta
            comando.Parameters.AddWithValue("@Usuario", login.Usuario);
            // recibe el parametro de el modelo de la capa entidad en login.Usuario y lo almacena en @Usuario

            leer = comando.ExecuteReader();   //ejecute la consulta
            if (leer.Read()) //condición va a leer un dato de la lista
            {
                result.Add(leer["Usuario"].ToString()); // que pase a string lo almancenado en usuario y lo añada a resultado
                result.Add(leer["Contraseña"].ToString());

            }

            comando.Connection = conexion.Cerrar_conexion();
            return result;
        }
    }
}
