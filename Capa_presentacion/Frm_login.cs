using Capa_entidad;
using Capa_negocio;
using System;
using System.Windows.Forms;

namespace Capa_presentacion
{
    public partial class Frm_login : Form
    {
        public Frm_login()
        {
            InitializeComponent();
        }

        Ce_login objCE = new Ce_login();
        CN_login objCN = new CN_login();

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            bool validacion;
            objCE.Usuario = txtusuario.Text;
            objCE.Contraseña = txtContraseña.Text;
            validacion = objCN.Lista(objCE);
            if (validacion == true)
            {
                lbl_alerta.Visible = false;
                Form1 menu = new Form1();
                menu.Show();
                this.Hide();
            }
            else
                lbl_alerta.Visible = true;
        }

    }
}

