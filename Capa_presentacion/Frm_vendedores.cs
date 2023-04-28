using Capa_entidad;
using Capa_negocio;
using Capa_presentacion.Clase_Validaciones;
using System;
using System.Data;
using System.Windows.Forms;

namespace Capa_presentacion
{
    public partial class Frm_vendedores : Form
    {
        CN_vendedor oCNvendedor = new CN_vendedor();
        CE_vendedor oCEvendedor = new CE_vendedor();

        public Frm_vendedores()
        {
            InitializeComponent();
        }
        public void Insertar_vendedor()
        {
            oCEvendedor.Codigo = Convert.ToInt32(txt_codigoV.Text);
            oCEvendedor.Usuario = txt_UsuarioV.Text;
            oCEvendedor.Contraseña = txt_contraseñaV.Text;
            oCEvendedor.Nombre = txt_nombreV.Text;
            oCNvendedor.Insertar_vendedor(oCEvendedor);
        }

        public void Limpiar()
        {
            txt_codigoV.Clear();
            txt_UsuarioV.Clear();
            txt_contraseñaV.Clear();
            txt_nombreV.Clear();
        }

        private void btn_guardarV_Click(object sender, EventArgs e)
        {
            if (txt_codigoV.Text == string.Empty || txt_nombreV.Text == string.Empty || txt_contraseñaV.Text == string.Empty || txt_UsuarioV.Text == string.Empty)
            {
                MessageBox.Show("Hay campos vacios.");
            }
            else
            {
                Insertar_vendedor();
                MessageBox.Show("Usuario creado con exito");
            }
        }

        private void btn_limpiarV_Click(object sender, EventArgs e)//limpiar textbox de vendedores
        {
            Limpiar();
        }

        public void Llenarcbovendedores()
        {
            //combobox de mostrar vendedores
            cbo_vendedorC.DataSource = oCNvendedor.Motrarvendedores();
            cbo_vendedorC.ValueMember = "Codigo";
            cbo_vendedorC.DisplayMember = "Nombre";
            //combobox de modificar vendedores
            cbo_vendedorM.DataSource = oCNvendedor.Motrarvendedores();
            cbo_vendedorM.ValueMember = "Codigo";
            cbo_vendedorM.DisplayMember = "Nombre";
            //combobox de eliminar
            cbo_vendedorE.DataSource = oCNvendedor.Motrarvendedores();
            cbo_vendedorE.ValueMember = "Codigo";
            cbo_vendedorE.DisplayMember = "Nombre";
        }

        private void Frm_vendedores_Load(object sender, EventArgs e)
        {
            Llenarcbovendedores();
            Llenardtgvendedores();
        }

        public void Llenardtgvendedores()
        {
            dtg_vendedores.DataSource = oCNvendedor.Motrarvendedores();
        }

        public void Filtrovendedor() //metodo busqueda por codigo de vendedor 
        {
            oCEvendedor.Codigo = (int)cbo_vendedorC.SelectedValue; //seleccionar de la lista de vendedores
            dtg_vendedores.DataSource = oCNvendedor.MostrarvendeEspe(oCEvendedor); //mostrar en dtg el vendedor especifico
        }

        private void btn_consultarV_Click(object sender, EventArgs e)
        {
            Filtrovendedor();
        }

        private void btn_vendedorM_Click(object sender, EventArgs e) // boton consultar
        {
            oCEvendedor.Codigo = (int)cbo_vendedorM.SelectedValue;
            DataTable tabla = oCNvendedor.MostrarvendeEspe(oCEvendedor);
            txtcodigoM.Text = tabla.Rows[0]["Codigo"].ToString(); //ponerlo readonly
            txt_usuarioM.Text = tabla.Rows[0]["Usuario"].ToString();
            txt_contraseñaM.Text = tabla.Rows[0]["Contraseña"].ToString();
            txt_nombreM.Text = tabla.Rows[0]["Nombre"].ToString();
        }

        private void btn_guardarMV_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Está seguro?", "Confirme la operación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                oCEvendedor.Codigo = Convert.ToInt32((int)cbo_vendedorM.SelectedValue);
                oCEvendedor.Usuario = txt_usuarioM.Text;
                oCEvendedor.Contraseña = txt_contraseñaM.Text;
                oCEvendedor.Nombre = txt_nombreM.Text;
                oCNvendedor.Actualizar_vendedor(oCEvendedor);
                MessageBox.Show("Vendedor guardado exitosamente");
            }
            else
            {
                MessageBox.Show("Regrese pronto!");
            }
        }

        private void btn_eliminarV_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Está seguro?", "Confirme la operación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                oCEvendedor.Codigo = (int)cbo_vendedorE.SelectedValue;
                oCNvendedor.Eliminar_vendedor(oCEvendedor);
                MessageBox.Show("Aceptado");
            }
            else
            {
                MessageBox.Show("Rechazado");
            }
        }

        private void txt_codigoV_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cp_Validaciones.SoloNum(e);
        }
    }
}
