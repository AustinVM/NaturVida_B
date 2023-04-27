using Capa_datos;
using Capa_entidad;
using System.Data;

namespace Capa_negocio
{
    public class CN_clientes
    {
        CD_clientes oCD_cliente = new CD_clientes();

        public DataTable Motrarcliente()
        {
            DataTable tabla = new DataTable();
            tabla = oCD_cliente.MostrarClientes();
            return tabla;
        }

        public DataTable MostrarclienteEspecifico(CE_clientes cliente)
        {
            DataTable tabla = new DataTable();
            tabla = oCD_cliente.MostrarClienteespecifico(cliente);
            return tabla;
        }

        public void Insertar_cliente(CE_clientes cliente)
        {
            oCD_cliente.Insertar_Cliente(cliente);
        }

        public void Actualizar_clientes(CE_clientes cliente) //tener en cuanta en la capa presentacion ya no tendria que convertir
        {
            oCD_cliente.Actualizar_clientes(cliente);
        }

        public void Eliminar_cliente(CE_clientes cliente)
        {
            oCD_cliente.Eliminar_clientes(cliente);
        }
    }
}
