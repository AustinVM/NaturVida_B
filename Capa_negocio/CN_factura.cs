using Capa_datos;
using Capa_entidad;

namespace Capa_negocio
{
    public class CN_factura
    {
        CD_factura objfact = new CD_factura();


        public void AgregarFactura(CE_factura factura)
        {

            objfact.AgregarFactura(factura);



        }
        public void AgregarDetallefactura(CE_detallefactura detalle)//recibe presentación
        {
            objfact.AgregarDetallefactura(detalle);//envia a capa datos

        }

    }
}
