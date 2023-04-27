using Capa_datos;
using Capa_entidad;
using System.Data;


namespace Capa_negocio
{

    public class CN_vendedor
    {
        CD_vendedor oCD_vendedor = new CD_vendedor();

        public DataTable Motrarvendedores()
        {
            DataTable tabla = new DataTable();
            tabla = oCD_vendedor.MostrarVendedores();
            return tabla;
        }
        public DataTable MostrarvendeEspe(CE_vendedor vendedor)
        {
            DataTable tabla = new DataTable();
            tabla = oCD_vendedor.Mostrarvendeespec(vendedor);
            return tabla;
        }
        public void Insertar_vendedor(CE_vendedor vendedor)
        {
            string contra = vendedor.Contraseña;
            vendedor.Contraseña = CN_login.GetSHA256(contra);
            oCD_vendedor.Insertar_vendedor(vendedor);
        }
        public void Actualizar_vendedor(CE_vendedor vendedor)
        {
            string contra = vendedor.Contraseña;
            vendedor.Contraseña = CN_login.GetSHA256(contra);
            oCD_vendedor.Actualizar_vendedor(vendedor);
        }
        public void Eliminar_vendedor(CE_vendedor vendedor)
        {
            oCD_vendedor.Eliminar_vendedor(vendedor);
        }
    }
}
