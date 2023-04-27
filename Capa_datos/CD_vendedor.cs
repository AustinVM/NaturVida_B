using Capa_entidad;
using System.Data;
using System.Data.SqlClient;

namespace Capa_datos
{
    public class CD_vendedor
    {

        CD_conexion conexion = new CD_conexion();
        SqlCommand comando = new SqlCommand();
        SqlDataReader leer;

        public DataTable MostrarVendedores()
        {
            comando.Parameters.Clear();
            DataTable tabla = new DataTable();
            comando.Connection = conexion.Abrir_conexion();
            comando.CommandText = "Mostrar_vendedores";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            comando.Connection = conexion.Cerrar_conexion();
            return tabla;
        }

        public DataTable Mostrarvendeespec(CE_vendedor vendedor)
        {
            comando.Parameters.Clear();
            DataTable tabla = new DataTable();
            comando.Connection = conexion.Abrir_conexion();
            comando.CommandText = "MostrarvendeEspe";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Codigo", vendedor.Codigo);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            comando.Connection = conexion.Cerrar_conexion();
            return tabla;
        }

        public void Insertar_vendedor(CE_vendedor vendedor)
        {
            comando.Parameters.Clear();
            comando.Connection = conexion.Abrir_conexion();
            comando.CommandText = "Insertar_vendedor";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Codigo", vendedor.Codigo);
            comando.Parameters.AddWithValue("@Usuario", vendedor.Usuario);
            comando.Parameters.AddWithValue("@Contraseña", vendedor.Contraseña);
            comando.Parameters.AddWithValue("@Nombre", vendedor.Nombre);
            comando.ExecuteNonQuery();
            comando.Connection = conexion.Cerrar_conexion();
        }

        public void Actualizar_vendedor(CE_vendedor vendedor)
        {
            comando.Parameters.Clear();
            comando.Connection = conexion.Abrir_conexion();
            comando.CommandText = "Actualizar_vendedor";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Codigo", vendedor.Codigo);
            comando.Parameters.AddWithValue("@Usuario", vendedor.Usuario);
            comando.Parameters.AddWithValue("@Contraseña", vendedor.Contraseña);
            comando.Parameters.AddWithValue("@Nombre", vendedor.Nombre);
            comando.ExecuteNonQuery();
            comando.Connection = conexion.Cerrar_conexion();
        }

        public void Eliminar_vendedor(CE_vendedor vendedor)
        {
            comando.Parameters.Clear();
            comando.Connection = conexion.Abrir_conexion();
            comando.CommandText = "Eliminar_vendedor";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Codigo", vendedor.Codigo);
            comando.ExecuteNonQuery();
            comando.Connection = conexion.Cerrar_conexion();
        }
    }
}
