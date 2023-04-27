using System;
using System.Windows.Forms;

namespace Capa_presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Mostrarpanel(new Frm_productos());

        }

        public void Mostrarpanel(Form form) //Método para cargar un formulario en un menustrip.
        {
            this.panel1.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(form);
            form.Show();

        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mostrarpanel(new Frm_factura());
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mostrarpanel(new Frm_clientes());
        }

        private void inventariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mostrarpanel(new Frm_inventario());
        }

        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mostrarpanel(new Frm_vendedores());
            ;
        }
    }
}
