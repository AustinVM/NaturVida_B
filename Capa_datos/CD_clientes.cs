using Capa_entidad;
using System.Data;
using System.Data.SqlClient;

namespace Capa_datos
{
    public class CD_clientes
    {
        CD_conexion conexion = new CD_conexion();
        SqlCommand comando = new SqlCommand();
        SqlDataReader leer;
        DataTable tabla = new DataTable();

        public DataTable MostrarClientes()  // Metodo para almacenar la informacion de la BD en una tabla que será retornada 
        {
            tabla.Clear();
            comando.Parameters.Clear();
            comando.Connection = conexion.Abrir_conexion();
            comando.CommandText = "Mostrar_clientes";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            comando.Connection = conexion.Cerrar_conexion();
            return tabla;
        }

        public DataTable MostrarClienteespecifico(CE_clientes clientes) // Metodo para almacenar la informacion de un cliente especifico en una tabla que sera retornada
        {
            tabla.Clear();
            comando.Parameters.Clear();
            comando.Connection = conexion.Abrir_conexion();
            comando.CommandText = "Mostrar_cliente_esp";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("Documento", clientes.Documento);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            comando.Connection = conexion.Cerrar_conexion();
            return tabla;
        }

        public void Insertar_Cliente(CE_clientes clientes)  // Metodo para insertar un cliente en la BD
        {
            comando.Parameters.Clear();
            comando.Connection = conexion.Abrir_conexion();
            comando.CommandText = "SP_INSERTARCLIENT";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Docu ", clientes.Documento);
            comando.Parameters.AddWithValue("@Nombre", clientes.Nombre);
            comando.Parameters.AddWithValue("@Direccion", clientes.Direccion);
            comando.Parameters.AddWithValue("@Tel", clientes.Telefono);
            comando.Parameters.AddWithValue("@Corr", clientes.Correo);
            comando.ExecuteNonQuery();
            comando.Connection = conexion.Cerrar_conexion();
        }

        public void Actualizar_clientes(CE_clientes clientes)
        {
            comando.Parameters.Clear();
            comando.Connection = conexion.Abrir_conexion();
            comando.CommandText = "SP_ACTUALCLIENT";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Docu", clientes.Documento);
            comando.Parameters.AddWithValue("@Nombre", clientes.Nombre);
            comando.Parameters.AddWithValue("@Direccion", clientes.Direccion);
            comando.Parameters.AddWithValue("@Tel", clientes.Telefono);
            comando.Parameters.AddWithValue("@Corr", clientes.Correo);
            comando.ExecuteNonQuery();
            comando.Connection = conexion.Cerrar_conexion();
        }

        public void Eliminar_clientes(CE_clientes clientes)
        {
            comando.Parameters.Clear();
            comando.Connection = conexion.Abrir_conexion();
            comando.CommandText = "SP_ELIMINARCLIENT";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Docu", clientes.Documento);
            comando.ExecuteNonQuery();
            comando.Connection = conexion.Cerrar_conexion();
        }
    }
}
