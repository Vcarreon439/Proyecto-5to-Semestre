using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using CustomControls.CheckBoxComboBox;
using Dominio;
using Elementos;
using Elementos.ElementosBiblioteca.Autor;
using FluentValidation.Results;
using MainForm.Auxiliares;
using MainForm.ValidateData;

namespace MainForm
{
    public partial class frnAddBook : Form
    {
        private ListasObjetos internalList;

        public frnAddBook()
        {
            InitializeComponent();
            internalList = new ListasObjetos();
            libroBindingSource.DataSource = new Libro();
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

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                libroBindingSource.EndEdit();
                Libro temp = libroBindingSource.Current as Libro;
                temp.Copias += 1;
                temp.numEdicion += 1;

                if (temp != null)
                {
                    ValidateBook validador = new ValidateBook();
                    ValidationResult resultado = validador.Validate(temp);
                    IList<ValidationFailure> fallas = resultado.Errors;

                    if (!resultado.IsValid)
                    {
                        foreach (ValidationFailure errors in fallas)
                        {
                            MessageBox.Show(errors.ErrorMessage, errors.PropertyName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    else
                    {
                        if (pctImagenLibro.Image != null)
                            temp.Imagen = Elementos.ImageConvertions.ImageToBase64(pctImagenLibro.Image, ImageFormat.Jpeg);
                        else
                            temp.Imagen = null;

                        temp.listaTemas = GenerarTemas();
                        temp.codEditorial = GenerarEditorial();
                        temp.listaAutores = GenerarAutores();

                        ModeloDUsuario mdDUsuario = new ModeloDUsuario();

                        if (mdDUsuario.AddBook(temp))
                        {
                            libroBindingSource.Clear();
                            cboTema.Text = "";
                            checkBoxComboBox1.Text = "";
                            MessageBox.Show("Se ha insertado el libro");
                        }
                    }

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

       

        private void FillCbo(ref ComboBox comboBox, List<EditorialSencillo> elemetos = null, List<Tema> temas = null)
        {
            comboBox.Items.Clear();

            foreach (EditorialSencillo editorial in elemetos)
                comboBox.Items.Add(editorial.Nombre);
        }

        private void FillCbo2(ref CheckBoxComboBox comboBox, List<Tema> temas = null)
        {
            comboBox.Items.Clear();

            foreach (Tema tem in temas)
                comboBox.Items.Add(tem.Descripcion);
        }

        private void FillCbo3(ref CheckBoxComboBox comboBox, List<AutorSimple> autores = null)
        {
            try
            {
                comboBox.Items.Clear();

                if (autores==null)
                    return;
                
                foreach (AutorSimple autor in autores)
                    comboBox.Items.Add((autor.Nombre + "_" + autor.Apellido));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private void cboTema_Enter(object sender, EventArgs e)
        {
            ListasObjetos.LoadTemas(ref internalList.Temas);
            FillCbo2(ref cboTema, internalList.Temas);
        }

        private List<Tema> GenerarTemas()
        {
            List<CheckBoxComboBoxItem> elementos = cboTema.CheckBoxItems.FindAll(x => x.CheckState == CheckState.Checked);
            List<Tema> lista = new List<Tema>();

            foreach (CheckBoxComboBoxItem el in elementos)
                lista.Add(new Tema(internalList.Temas.Find(x => x.Descripcion == el.Text).Codigo, el.Text));

            return lista;
        }

        private string GenerarEditorial()
        {
            return internalList.Editoriales.Find(x => x.Nombre == codEditorialComboBox.Text).Codigo;
        }

        private List<AutorSimple> GenerarAutores()
        {
            List<AutorSimple> listaAutorSimples = new List<AutorSimple>();

            foreach (CheckBoxComboBoxItem item in checkBoxComboBox1.CheckBoxItems.FindAll(x=>x.CheckState == CheckState.Checked))
            {
                listaAutorSimples.Add(new AutorSimple
                    (
                        internalList.Autores.Find(x=> x.Nombre == item.Text.Split('_')[0] && x.Apellido == item.Text.Split('_')[1]).Codigo
                        ));
            }

            foreach (AutorSimple autor in listaAutorSimples)
            {
                Console.WriteLine($"{autor.Codigo}");
            }

            return listaAutorSimples;
        }

        private void codEditorialComboBox_Enter(object sender, EventArgs e)
        {
            ListasObjetos.LoadEditoriales(ref internalList.Editoriales);
            FillCbo(ref codEditorialComboBox, internalList.Editoriales);
        }

        private void checkBoxComboBox1_Enter(object sender, EventArgs e)
        {
            ListasObjetos.LoadAutores(ref internalList.Autores);
            FillCbo3(ref checkBoxComboBox1, internalList.Autores);
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            //
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pctImagenLibro.Image = new Bitmap(open.FileName);
                imgLocation = open.FileName;
            }
        }
    }
}
