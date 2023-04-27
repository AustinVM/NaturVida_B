using System;

namespace Capa_entidad
{
    public class CE_factura
    {
        public int IdFactura { get; set; }
        public DateTime Fecha { get; set; }
        public int Documento_Cliente { get; set; }
        public int Codido_Vendedor { get; set; }
    }
}
