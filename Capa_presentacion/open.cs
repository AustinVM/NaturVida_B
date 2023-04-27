using System;
using System.Windows.Forms;

namespace Capa_presentacion
{
    public partial class open : Form
    {
        public open()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter = "Archivo sql (*.sql) | *.sql | Archivo txt (*.txt) | *txt";// Archivo txt(*.txt)= tipo de archivo que muestra en el formulario, tipo de archivo| 
            openFileDialog1.Title = "Abrir"; //titulo del formulario
            openFileDialog1.InitialDirectory = @"C:\Users\Sena CSET\Downloads\Exposicion2";
            if (openFileDialog1.ShowDialog() == DialogResult.OK) //cuadro de dialogo 
                                                                 //openfile.inicialdirectorio 
            {
                textBox1.Text = openFileDialog1.FileName; //

            }
            openFileDialog1.Dispose();//libera recursos (limpiar)
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Archivo txt (*.txt)| ";
            saveFileDialog1.Title = "Guardar";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                textBox3.Text = saveFileDialog1.FileName;
            }
            saveFileDialog1.Dispose();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //no
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {
            //no
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();//instaciamos la clase y usamos el objeto
            fbd.Description = "Selecione la ruta";
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = fbd.SelectedPath;
            }
            fbd.Dispose();
        }

    }
}
