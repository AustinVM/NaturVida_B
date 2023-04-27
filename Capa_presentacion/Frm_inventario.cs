using Capa_entidad;
using Capa_negocio;
using System;
using System.Windows.Forms;

namespace Capa_presentacion
{
    public partial class Frm_inventario : Form
    {
        CN_productos oCNproductos = new CN_productos();
        CE_productos oCEproductos = new CE_productos();

        public Frm_inventario()
        {
            InitializeComponent();
        }

        private void Frm_inventario_Load(object sender, EventArgs e)
        {
            LlenardtgInventario();
            Llenarcboinventario();
        }
        public void LlenardtgInventario()
        {
            dtg_inventario.DataSource = oCNproductos.MostrarInventario();
        }
        public void Llenarcboinventario()
        {
            cbo_productoIn.DataSource = oCNproductos.Mostrar();
            cbo_productoIn.DisplayMember = "Descripción";
            cbo_productoIn.ValueMember = "Codigo";
        }

        private void btn_consultarIn_Click(object sender, EventArgs e)
        {
            dtg_inventario.DataSource = oCNproductos.MostrarInventarioProd(Convert.ToInt32(cbo_productoIn.SelectedValue));
        }

        private void btn_mostrarIn_Click(object sender, EventArgs e)
        {
            LlenardtgInventario();
        }
    }
}
