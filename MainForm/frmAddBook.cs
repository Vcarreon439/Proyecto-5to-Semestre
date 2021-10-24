using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomControls.CheckBoxComboBox;
using Dominio;
using Elementos;

namespace MainForm
{
    public partial class frnAddBook : Form
    {
        public frnAddBook()
        {
            InitializeComponent();
            pctImagenLibro.AllowDrop = true;
        }

        private string imgLocation;
        private void pctImagenLibro_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            string[] fileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            if (data != null)
            {
                var filename = data as string[];

                if (filename.Length > 0)
                {
                    pctImagenLibro.Image = Image.FromFile((filename[0]));
                    imgLocation = fileList[0];
                }
            }
        }

        private void pctImagenLibro_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void frnAddBook_Load(object sender, EventArgs e)
        {
            FillEditoriales();
        }


        private List<EditorialSencillo> listaEditorialSencillos;

        private async void FillEditoriales()
        {
            try
            {
                ModeloDUsuario Obj = new ModeloDUsuario();
                listaEditorialSencillos = Obj.Editoriales100();

                if (listaEditorialSencillos != null)
                {
                    foreach (EditorialSencillo editorial in listaEditorialSencillos)
                        cboEditorial.Items.Add(editorial.Nombre);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private Libro GenerarLibro()
        {
            Libro tempLibro = new Libro();
            tempLibro.Descripcion = txtDescripcion.Text;
            tempLibro.Titulo = txtTitulo.Text;
            tempLibro.ISBN = txtISBN.Text;
            tempLibro.Copias = int.Parse(numCopias.Value.ToString());
            tempLibro.AñoEdicion = txtAño.Text;
            tempLibro.codEditorial = "1";
            tempLibro.numEdicion = int.Parse(numEdicion.Value.ToString());
            tempLibro.Imagen = ImageConvertions.ImageToBase64(pctImagenLibro.Image, ImageFormat.Jpeg);
            return tempLibro;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Libro libro = GenerarLibro();
            ModeloDUsuario Obj = new ModeloDUsuario();
            if (Obj.AddBook(libro))
                MessageBox.Show("Si se inserto");
            else
                MessageBox.Show("No se inserto");
            

            List<CheckBoxComboBoxItem> lista = cbochkAutores.CheckBoxItems.FindAll(new Predicate<CheckBoxComboBoxItem>(x=> x.Checked==true));

            string aa = " ";
        }
    }
}
