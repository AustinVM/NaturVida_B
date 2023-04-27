using Capa_entidad;
using System.Data;
using System.Data.SqlClient;

namespace Capa_datos
{
    public class CD_productos
    {
        SqlCommand comando = new SqlCommand();
        SqlDataReader leer;
        CD_conexion conexion = new CD_conexion();

        public DataTable Mostrar()
        {
            comando.Parameters.Clear();
            DataTable tabla = new DataTable();
            comando.Connection = conexion.Abrir_conexion();
            comando.CommandText = "SP_MOSTRARPROD";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            comando.Connection = conexion.Cerrar_conexion();

            return tabla;
        }

        public DataTable Mostrar_Especifico(CE_productos mostrar_especifico)
        {
            comando.Parameters.Clear();
            DataTable tabla = new DataTable();
            comando.Connection = conexion.Abrir_conexion();
            comando.CommandText = "SP_MOSTRARPRODESPEC";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Cod", mostrar_especifico.Codigo);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            comando.Connection = conexion.Cerrar_conexion();
            return tabla;
        }

        public void SP_INSERTARPRODUCT(CE_productos insertarproducto)
        {
            comando.Parameters.Clear();
            comando.Connection = conexion.Abrir_conexion();
            comando.CommandText = "SP_INSERTARPRODUCT";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Codigo", insertarproducto.Codigo);
            comando.Parameters.AddWithValue("@Descri", insertarproducto.Descripión);
            comando.Parameters.AddWithValue("@ValUnd", insertarproducto.Valor_Unidad);
            comando.Parameters.AddWithValue("@Cantida", insertarproducto.Cantidad);
            comando.ExecuteNonQuery();
            comando.Connection = conexion.Cerrar_conexion();

        }

        public void SP_ACTUALIZARPROD(CE_productos actualizarproductos)
        {
            comando.Parameters.Clear();
            comando.Connection = conexion.Abrir_conexion();
            comando.CommandText = "SP_ACTUALIZARPROD";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Cod", actualizarproductos.Codigo);
            comando.Parameters.AddWithValue("@Descri", actualizarproductos.Descripión);
            comando.Parameters.AddWithValue("@ValUnd", actualizarproductos.Valor_Unidad);
            comando.Parameters.AddWithValue("@Cant", actualizarproductos.Cantidad);
            comando.ExecuteNonQuery();
            comando.Connection = conexion.Cerrar_conexion();
        }

        public void SP_ELIMINARPROD(CE_productos eliminarproductos)
        {
            comando.Parameters.Clear();
            comando.Connection = conexion.Abrir_conexion();
            comando.CommandText = "SP_ELIMINARPROD";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Cod", eliminarproductos.Codigo);
            comando.ExecuteNonQuery();
            comando.Connection = conexion.Cerrar_conexion();
        }

        public DataTable MostrarInventario()
        {
            DataTable dt = new DataTable();
            comando.Connection = conexion.Abrir_conexion();
            comando.CommandText = "SP_BUSCARINVENTARIOS";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            dt.Load(leer);
            comando.Connection = conexion.Cerrar_conexion();
            return dt;
        }

        public DataTable MostrarInventarioProd(int CodProd)
        {
            DataTable dt = new DataTable();
            comando.Parameters.Clear();
            comando.Connection = conexion.Abrir_conexion();
            comando.CommandText = "SP_BUSCARINVENTARIO";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Cod", CodProd);
            leer = comando.ExecuteReader();
            dt.Load(leer);
            comando.Connection = conexion.Cerrar_conexion();
            return dt;
        }
    }
}
