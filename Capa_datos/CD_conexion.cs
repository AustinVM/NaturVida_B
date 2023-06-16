using System.Data;
using System.Data.SqlClient;

namespace Capa_datos
{
    public class CD_conexion
    {
        //private SqlConnection conexion = new SqlConnection("Server=localhost;Database=NaturVida;Integrated Security=true;"); //cadena de conexión
        private SqlConnection conexion = new SqlConnection("Data Source=sql8005.site4now.net;Initial Catalog=db_a982ec_naturvida;User Id=db_a982ec_naturvida_admin;Password=NaturVida.123*;"); //cadena de conexión
        
        public SqlConnection Abrir_conexion() //Metodo para abrir conexión a la base de datos.
        {
            if (conexion.State == ConnectionState.Closed)
                conexion.Open();
            return conexion;
        }
        public SqlConnection Cerrar_conexion() //Metodo para cerrar conexión a la base de datos.
        {
            if (conexion.State == ConnectionState.Open)
                conexion.Close();
            return conexion;
        }

    }
}
