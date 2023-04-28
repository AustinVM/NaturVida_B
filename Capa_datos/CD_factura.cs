using Capa_entidad;
using System.Data;
using System.Data.SqlClient;

namespace Capa_datos
{
    public class CD_factura
    {
        CD_conexion conexion = new CD_conexion();
        SqlCommand comando = new SqlCommand();

        public void AgregarFactura(CE_factura factura)
        {
            comando.Parameters.Clear();
            comando.Connection = conexion.Abrir_conexion();
            comando.CommandText = "SP_AGGFACT";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Fech", factura.Fecha);
            comando.Parameters.AddWithValue("@DoClient", factura.Documento_Cliente);
            comando.Parameters.AddWithValue("@CodVende", factura.Codido_Vendedor);
            comando.ExecuteNonQuery();
            comando.Connection = conexion.Cerrar_conexion();
        }

        public void AgregarDetallefactura(CE_detallefactura detalle) //metodo de agregar detalle de factura
        {
            try
            {
                comando.Parameters.Clear();
                comando.Connection = conexion.Abrir_conexion();
                comando.CommandText = "SP_AGGFACTDETA";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@CodProd", detalle.Codigo_Productos);
                comando.Parameters.AddWithValue("@Cant", detalle.Cantidad);
                comando.Parameters.AddWithValue("@ValUnidad", detalle.Valor_Unidad);
                comando.ExecuteNonQuery();
                comando.Connection = conexion.Cerrar_conexion();
            }
            catch (System.Exception)
            {
                System.Console.WriteLine("lol");
            }
        }
    }
}
