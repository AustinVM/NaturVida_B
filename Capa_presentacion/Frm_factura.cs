using Capa_entidad;
using Capa_negocio;
using Capa_presentacion.Clase_Validaciones;
using System;
using System.Data;
using System.Windows.Forms;

namespace Capa_presentacion
{
    public partial class Frm_factura : Form
    {
        CN_clientes objCNCliente = new CN_clientes();
        CN_vendedor objCNVendedor = new CN_vendedor();
        CN_productos objCNpro = new CN_productos();
        private double acum = 0;

        public Frm_factura()
        {
            InitializeComponent();
        }

        public void LlenarComboX()
        {
            cmbvendedor.DataSource = objCNVendedor.Motrarvendedores();
            cmbvendedor.DisplayMember = "Usuario"; //informacion que muestra en el combobox
            cmbvendedor.ValueMember = "Codigo";

            cmbcliente.DataSource = objCNCliente.Motrarcliente();
            cmbcliente.DisplayMember = "Nombre"; //informacion que muestra en el combobox
            cmbcliente.ValueMember = "Documento";

            cmbproductos.DataSource = objCNpro.Mostrar();
            cmbproductos.DisplayMember = "Descripción"; //informacion que muestra en el combobox
            cmbproductos.ValueMember = "Codigo";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LlenarComboX();
        }

        public void LlenarDatagridview()//método para llenar datagridview 
        {
            CE_productos valunidad = new CE_productos();//Se hace una instancia de la capa negocio productos

            if (valCantidad() == true)  // Valida el campo de cantidad
            {
                MessageBox.Show("El campo de cantidad no puede contener letras.");
            }
            else
            {
                valunidad.Codigo = Convert.ToInt32(cmbproductos.SelectedValue.ToString());
                DataTable tabla = objCNpro.Mostrar_Especifico(valunidad);

                if (Convert.ToInt32(txtCantidad.Text) <= 0)  // Verifica si la cantidad es menor o igual a cero
                {
                    MessageBox.Show("Cantidad invalida");
                }
                else if (Convert.ToInt32(tabla.Rows[0]["Cantidad"]) - Convert.ToInt32(txtCantidad.Text) < 0) // Verifica que no se se este vendiendo mas de lo que hay en stock
                {
                    MessageBox.Show("No es posible vender más de la cantidad en inventario.");
                }
                else  // Si todo lo anterior no se cumple, agrega al datagrid
                {
                    string[] registro = new string[]
                    {
                        cmbvendedor.SelectedValue.ToString(), dateTimePicker1.Text,
                        cmbcliente.SelectedValue.ToString(), cmbproductos.SelectedValue.ToString(),
                        txtCantidad.Text, tabla.Rows[0]["Valor_Unidad"].ToString()
                    };
                    dataGridView1.Rows.Add(registro);

                }
            }
        }

        public void TotalFactura()
        {
            int totalFact = 0;

            foreach (DataGridViewRow c in dataGridView1.Rows)
            {
                totalFact = Convert.ToInt32(c.Cells[4].Value) * Convert.ToInt32(c.Cells[5].Value);
                acum += totalFact;
            }

            txttotalfactura.Text = acum.ToString();
        }

        private void btn_agregarPro_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCantidad.Text))
            {
                MessageBox.Show("El campo de cantidad no puede estar vacio");
            }
            else
            {
                LlenarDatagridview();
                TotalFactura();
            }
        }

        private void EnviarBD()  // Metodo para enviar la factura a la base de datos
        {
            CE_factura objCefactura = new CE_factura();
            CN_factura objCNfactura = new CN_factura();

            objCefactura.Codido_Vendedor = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            objCefactura.Fecha = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[1].Value);
            objCefactura.Documento_Cliente = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value);

            objCNfactura.AgregarFactura(objCefactura);

            foreach (DataGridViewRow registrodatagrid in dataGridView1.Rows)
            {
                CE_detallefactura objCedetallefactura = new CE_detallefactura();
                objCedetallefactura.Codigo_Productos = Convert.ToInt32(registrodatagrid.Cells[3].Value);
                objCedetallefactura.Cantidad = Convert.ToInt32(registrodatagrid.Cells[4].Value);
                objCedetallefactura.Valor_Unidad = Convert.ToInt32(registrodatagrid.Cells[5].Value);
                objCNfactura.AgregarDetallefactura(objCedetallefactura);
            }

            MessageBox.Show("Se guardo correctamente.");
            dataGridView1.Rows.Clear();
        }

        private void bntcantidad_Click(object sender, EventArgs e)
        {
            EnviarBD();
        }

        public void limpiar()
        {
            txtCantidad.Clear();
            txttotalfactura.Clear();
        }

        private bool valCantidad()
        {
            bool error = false;

            foreach (char c in txtCantidad.Text)
            {
                if (!char.IsDigit(c))
                {
                    error = true;
                    break;
                }
            }

            return error;
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cp_Validaciones.SoloNum(e);
        }
    }
}
