using Capa_entidad;
using Capa_negocio;
using Capa_presentacion.Clase_Validaciones;
using System;
using System.Data;
using System.Windows.Forms;

namespace Capa_presentacion
{
    public partial class Frm_productos : Form
    {
        CN_productos obj_capan = new CN_productos();
        CE_productos obje = new CE_productos(); //creamos un objeto de la capa entidades
        public Frm_productos()
        {
            InitializeComponent();
        }

        private void Form_productos_Load(object sender, EventArgs e)
        {
            Mostrardatagridview();
            LlenarCombobox(); //metodo que llena el combobox
            lblcodigoya.Visible = false;
        }

        public void Mostrardatagridview() //método para mostrar un datagridview
        {
            dataGridView1.DataSource = obj_capan.Mostrar();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            Mostrardatagridview();
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            Flitrarproductos();
        }
        public void LlenarCombobox()
        {
            //Cargar datos de tabla productos en cboproductos Displaymember=lo que el usuario ve && Valuemember=primarykey de la tabla productos. 
            cmbproductos.DataSource = obj_capan.Mostrar(); //carga el cbo desde el PA.Mostrar
            cmbproductos.DisplayMember = "Descripción"; //informacion que muestra en el combobox
            cmbproductos.ValueMember = "Codigo";  // nombre de la llave primaria

            cmbeliminar.DataSource = obj_capan.Mostrar();
            cmbeliminar.DisplayMember = "Descripción"; //informacion que muestra en el combobox
            cmbeliminar.ValueMember = "Codigo";  // nombre de la llave primaria

            comboBox1.DataSource = obj_capan.Mostrar();
            comboBox1.DisplayMember = "Descripción"; //informacion que muestra en el combobox
            comboBox1.ValueMember = "Codigo";  // nombre de la llave primaria
        }

        public void Flitrarproductos() //método para filtrar productos seleccionado del combobox
        {
            CE_productos obje = new CE_productos(); //instanciamos la capa negocio

            obje.Codigo = (int)cmbproductos.SelectedValue; //codigo(CE)=valor seleccionado en el combobox 
            dataGridView1.DataSource = obj_capan.Mostrar_Especifico(obje); //se muestra en dtgproductos=el metodo mostrar prooducto especifico
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (txtcodigo.Text == string.Empty ||
                txtdescripcion.Text == string.Empty ||
                txtvalor.Text == string.Empty ||
                txtcantidad.Text == string.Empty ||
                txtcantidad.Text == string.Empty)
            {
                MessageBox.Show("Error ingrese los datos");
            }
            else
            {
                obje.Codigo = Convert.ToInt32(txtcodigo.Text); //se hace la conversión a entero en la capa presentación 
                obje.Descripión = (txtdescripcion.Text);
                obje.Cantidad = Convert.ToInt32(txtcantidad.Text);
                obje.Valor_Unidad = Convert.ToInt32(txtvalor.Text);
                obj_capan.Insertarproductos(obje);
                MessageBox.Show("Producto guardado exitosamente");
                limpiar();
            }
        }

        public bool Ingresarnuevo()
        {
            bool n = false;
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                if (txtcodigo.Text == fila.Cells[0].Value.ToString())
                {
                    n = true;
                    break;
                }
            }
            return n;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            CE_productos objce = new CE_productos(); //instanciamos la capa de negocio para poder obtener el parametro código 

            respuesta = MessageBox.Show("¿Está seguro?", "Confirme la operación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                objce.Codigo = (int)cmbeliminar.SelectedValue;
                obj_capan.Eliminarproductos(objce);
                MessageBox.Show("Aceptado");
            }
            else
            {
                MessageBox.Show("Rechazado");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)//boton guardar en modificar
        {
            DialogResult respuesta;
            CE_productos objce = new CE_productos(); //instanciamos la capa de negocio para poder obtener el parametro código 

            respuesta = MessageBox.Show("¿Está seguro?", "Confirme la operación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                objce.Codigo = Convert.ToInt32(comboBox1.SelectedValue); //se hace la conversion en la capa presentacion 
                objce.Descripión = (txtDescripcionActualizar.Text);
                objce.Cantidad = Convert.ToInt32(txtCantidadActualizar.Text);
                objce.Valor_Unidad = Convert.ToInt32(txtVAlorUnidadActualizar.Text);
                obj_capan.Actulizarproductos(objce);
            }
            else
            {
                MessageBox.Show("Regrese pronto!");
            }
        }

        private void btnConsultarAct_Click(object sender, EventArgs e)//consulta especifica en modificar
        {
            CE_productos objce = new CE_productos();
            objce.Codigo = Convert.ToInt32(comboBox1.SelectedValue);

            DataTable dt = obj_capan.Mostrar_Especifico(objce);//se guarda  en una tabla cada uno de los parametros

            txtDescripcionActualizar.Text = dt.Rows[0]["Descripción"].ToString();//ver como acomodar
            txtVAlorUnidadActualizar.Text = dt.Rows[0]["Valor_Unidad"].ToString();
            txtCantidadActualizar.Text = dt.Rows[0]["Cantidad"].ToString();

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtDescripcionActualizar.Clear();
            txtVAlorUnidadActualizar.Clear();
            txtCantidadActualizar.Clear();
        }

        public void limpiar()
        {
            txtcantidad.Clear();
            txtcodigo.Clear();
            txtdescripcion.Clear();
            txtvalor.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {
            if (ProdExiste() == true)
            {
                lblcodigoya.Visible = true;
            }
            else
            {
                lblcodigoya.Visible = false;
            }
        }

        private void txtdescripcion_TextChanged(object sender, EventArgs e)
        {
            //if (ProdExiste() == true)
            //{
            //    lblcodigoya.Visible = true;
            //}
            //else
            //{
            //    lblcodigoya.Visible = false;
            //}
        }

        private bool ProdExiste() // Metodo para validar si un producto ya existe
        {
            DataTable dt = new DataTable();
            bool existe = false;
            CE_productos ProdYaExiste = new CE_productos();
            if (string.IsNullOrEmpty(txtcodigo.Text))  // Mira que la caja de texto de codigo no este vacia o sea null
            {
                lblcodigoya.Text = "Digite un codigo";
            }
            else
            {
                ProdYaExiste.Codigo = Convert.ToInt32(txtcodigo.Text);
                dt = obj_capan.Mostrar_Especifico(ProdYaExiste);
                if (dt.Rows.Count == 0)
                {
                    existe = false;
                }
                else
                {
                    existe = true;
                }
            }

            return existe;
        }

        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cp_Validaciones.SoloNum(e);
        }

        private void txtvalor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cp_Validaciones.SoloNum(e);
        }

        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cp_Validaciones.SoloNum(e);
        }
    }
}


//if (Convert.ToInt32(dt.Rows[0]["Codigo"]) == Convert.ToInt32(txtcodigo.Text) || dt.Rows[0]["Descripción"].ToString() == txtdescripcion.Text)
//{
//    existe = true;
//}
//else
//{
//    existe = false;
//}