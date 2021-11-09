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
using MainForm.ValidateData;

namespace MainForm
{
    public partial class frnAddBook : Form
    {
        internal class ListasObjetos
        {
            public List<EditorialSencillo> Editoriales;
            public List<Tema> Temas;
            public List<AutorSimple> Autores;

            public ListasObjetos()
            {
                Editoriales = new List<EditorialSencillo>();
                Temas = new List<Tema>();
                Autores = new List<AutorSimple>();
            }

            public static void LoadEditoriales(ref List<EditorialSencillo> listaEditoriales)
            {
                ModeloDUsuario objDUsuario = new ModeloDUsuario();
                listaEditoriales = objDUsuario.LoadEditoriales();
            }

            public static void LoadTemas(ref List<Tema> listaTemas)
            {
                ModeloDUsuario objDUsuario = new ModeloDUsuario();
                listaTemas = objDUsuario.LoadTemas();
            }

            public static void LoadAutores(ref List<AutorSimple> listaAutores)
            {
                ModeloDUsuario objDUsuario = new ModeloDUsuario();
                listaAutores = objDUsuario.LoadAutores();
            }

        }

        private ListasObjetos internalList;

        public frnAddBook()
        {
            InitializeComponent();
            internalList = new ListasObjetos();
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
                        ModeloDUsuario mdDUsuario = new ModeloDUsuario();

                        //if (mdDUsuario.AddAuthor(temp))
                        //{
                        //    pctPrueba.Image = null;
                        //    fullAutorBindingSource.Clear();
                        //    fullAutorBindingSource.DataSource = new FullAutor();

                        //    if (forma != null)
                        //        forma.Refresh();
                        //}
                    }

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void cboEditorial_Enter(object sender, EventArgs e)
        {
            ListasObjetos.LoadEditoriales(ref internalList.Editoriales);
            FillCbo(ref codEditorialComboBox, internalList.Editoriales);
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
            comboBox.Items.Clear();

            foreach (AutorSimple autor in autores)
                comboBox.Items.Add((autor.Nombre + " " + autor.Apellido));
        }

        private void cboTema_Enter(object sender, EventArgs e)
        {
            ListasObjetos.LoadTemas(ref internalList.Temas);
            FillCbo2(ref cboTema, internalList.Temas);
        }

        private void cbochkAutores_Enter(object sender, EventArgs e)
        {
            ListasObjetos.LoadAutores(ref internalList.Autores);
            FillCbo3(ref cbochkAutores, internalList.Autores);
        }

        private void iSBNTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            List<CheckBoxComboBoxItem> elementos = cboTema.CheckBoxItems.FindAll(x => x.CheckState == CheckState.Checked);
            List<Tema> lista = new List<Tema>();

            foreach (CheckBoxComboBoxItem el in elementos)
                lista.Add(new Tema(internalList.Temas.Find(x => x.Descripcion == el.Text).Codigo, el.Text));

            foreach (Tema tt in lista)
                Console.WriteLine($"{tt.Codigo} - {tt.Descripcion}");
        }
    }
}
