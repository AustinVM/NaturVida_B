using Capa_entidad;
using Capa_negocio;
using Capa_presentacion.Clase_Validaciones;
using System;
using System.Data;
using System.Windows.Forms;

namespace Capa_presentacion
{
    public partial class Frm_clientes : Form
    {
        CN_clientes oCNcliente = new CN_clientes();
        CE_clientes oCEcliente = new CE_clientes();

        public Frm_clientes()
        {
            InitializeComponent();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        public void Limpiar()
        {
            txt_nombre.Clear();
            txt_documento.Clear();
            txt_direccion.Clear();
            txt_telf.Clear();
            txt_mail.Clear();
            txtNombreM.Clear();
            txt_direccionM.Clear();
            txt_telM.Clear();
            txt_mailM.Clear();
        }


        public void Llenardtgclientes()
        {
            dtg_clientes.DataSource = oCNcliente.Motrarcliente();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            oCEcliente.Documento = Convert.ToInt32(txt_documento.Text);
            DataTable dt = oCNcliente.MostrarclienteEspecifico(oCEcliente);

            if (txt_documento.Text == string.Empty ||
                txt_nombre.Text == string.Empty ||
                txt_direccion.Text == string.Empty ||
                txt_telf.Text == string.Empty ||
                txt_mail.Text == string.Empty)
            {
                MessageBox.Show("Error, ingrese los datos");
            }
            else
            {
                if (txt_documento.Text == dt.Rows[0]["Documento"].ToString())
                {
                    MessageBox.Show("Cliente existente");
                }
                else if (Cp_Validaciones.ValidarCorreoElectronico(txt_mailM.Text) == false)
                {
                    MessageBox.Show("Correo no valido");
                }
                else
                {
                    oCEcliente.Nombre = (txt_nombre.Text);
                    oCEcliente.Documento = Convert.ToInt32(txt_documento.Text);
                    oCEcliente.Direccion = (txt_direccion.Text);
                    oCEcliente.Telefono = (txt_telf.Text);
                    oCEcliente.Correo = (txt_mail.Text);
                    oCNcliente.Insertar_cliente(oCEcliente);
                    MessageBox.Show("Creado exitosamente");
                    Limpiar();
                    txt_documento.Focus();
                    Llenardtgclientes(); //se llena el dtgclientes 
                    Llenarcboclientes(); //carge el form se llena el combobox
                }
            }
        }

        private void Frm_clientes_Load(object sender, EventArgs e)//carga el formulario clientes
        {
            Llenardtgclientes(); //se llena el dtgclientes 
            Llenarcboclientes(); //carge el form se llena el combobox
        }

        public void Llenarcboclientes() //método para llenar todos los combobox del crud clientes
        {
            //llenar cbo consulta de cliente
            cbo_clienteC.DataSource = oCNcliente.Motrarcliente();
            cbo_clienteC.DisplayMember = "Nombre";
            cbo_clienteC.ValueMember = "Documento";

            //llenar cbo modificar cliente 
            cbo_clienteM.DataSource = oCNcliente.Motrarcliente();
            cbo_clienteM.DisplayMember = "Nombre";
            cbo_clienteM.ValueMember = "Documento";

            //lLenar cbo eliminar cliente
            cbo_clienteE.DataSource = oCNcliente.Motrarcliente();
            cbo_clienteE.DisplayMember = "Nombre";
            cbo_clienteE.ValueMember = "Documento";
        }

        public void FiltrarCliente() //método que busca cliente especifico en el datagriview
        {
            CE_clientes Consultar = new CE_clientes();
            Consultar.Documento = Convert.ToInt32(cbo_clienteC.SelectedValue);
            dtg_clientes.DataSource = oCNcliente.MostrarclienteEspecifico(Consultar);
        }

        private void btn_consultarC_Click(object sender, EventArgs e)
        {
            FiltrarCliente();
        }

        private void btn_consultarM_Click(object sender, EventArgs e)
        {
            CE_clientes Consultar = new CE_clientes();
            Consultar.Documento = Convert.ToInt32(cbo_clienteM.SelectedValue);
            DataTable tabla = oCNcliente.MostrarclienteEspecifico(Consultar);
            txtNombreM.Text = tabla.Rows[0]["Nombre"].ToString();
            txt_direccionM.Text = tabla.Rows[0]["Direccion"].ToString();
            txt_telM.Text = tabla.Rows[0]["Telefono"].ToString();
            txt_mailM.Text = tabla.Rows[0]["Correo"].ToString();
        }

        private void btn_guardarM_Click(object sender, EventArgs e)
        {
            if (txtNombreM.Text == string.Empty || txt_direccionM.Text == string.Empty || txt_telM.Text == string.Empty || txt_mailM.Text == string.Empty)
            {
                MessageBox.Show("No pueden haber campos vacios.");
            }
            else if (Cp_Validaciones.ValidarCorreoElectronico(txt_mailM.Text) == false)
            {
                MessageBox.Show("Correo no valido");
            }
            else
            {
                oCEcliente.Documento = Convert.ToInt32(cbo_clienteM.SelectedValue);
                oCEcliente.Nombre = txtNombreM.Text;
                oCEcliente.Direccion = txt_direccionM.Text;
                oCEcliente.Telefono = txt_telM.Text;
                oCEcliente.Correo = txt_mailM.Text;
                oCNcliente.Actualizar_clientes(oCEcliente);
                MessageBox.Show("Cliente guardado exitosamente");
                Limpiar();
            }
        }

        private void txt_mailM_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_mostrarC_Click(object sender, EventArgs e)
        {
            Llenardtgclientes();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro?", "Operación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                oCEcliente.Documento = (int)cbo_clienteE.SelectedValue;
                oCNcliente.Eliminar_cliente(oCEcliente);
                MessageBox.Show("Aceptado");
            }
            else
            {
                MessageBox.Show("Rechazado");
            }
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingresa solo letras ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_documento_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cp_Validaciones.SoloNum(e);
        }

        private void txt_telf_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cp_Validaciones.SoloNum(e);
        }

        private void txt_telM_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cp_Validaciones.SoloNum(e);
        }
    }
}
