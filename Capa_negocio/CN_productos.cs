using Capa_datos;
using Capa_entidad;
using System.Data;
using System;

namespace Capa_negocio
{
    public class CN_productos
    {
        CD_productos oD_Productos = new CD_productos();

        public DataTable Mostrar()
        {
            DataTable tabla = new DataTable();
            tabla = oD_Productos.Mostrar();
            return tabla;
        }
        public DataTable Mostrar_Especifico(CE_productos mostrar_Especifico)
        {
            DataTable tabla = new DataTable();
            tabla = oD_Productos.Mostrar_Especifico(mostrar_Especifico);
            return tabla;
        }
        public void Insertarproductos(CE_productos insertarproductos)
        {
            oD_Productos.SP_INSERTARPRODUCT(insertarproductos);
        }

        public void Actulizarproductos(CE_productos actulizarproductos)
        {
            oD_Productos.SP_ACTUALIZARPROD(actulizarproductos);
        }

        public void Eliminarproductos(CE_productos eliminarproductos)
        {
            oD_Productos.SP_ELIMINARPROD(eliminarproductos);
        }

        public DataTable MostrarInventario()
        {
            DataTable dt = oD_Productos.MostrarInventario();
            return dt;
        }

        public DataTable MostrarInventarioProd(int CodProd)
        {
            DataTable dt = oD_Productos.MostrarInventarioProd(CodProd);
            return dt;
        }
    }
}
