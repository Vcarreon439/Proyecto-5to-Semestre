using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using Dominio;
using Elementos.ElementosBiblioteca.Autor;
using Elementos;
using FluentValidation.Results;
using MainForm.ValidateData;

namespace MainForm
{
    public partial class addAuthors : Form
    {
        protected FullAutor selectedAutor;
        protected FullAutor updatedAutor;
        private tableAuthor forma;


        public addAuthors()
        {
            InitializeComponent();
            fullAutorBindingSource.DataSource = new FullAutor();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                fullAutorBindingSource.EndEdit();
                FullAutor temp = fullAutorBindingSource.Current as FullAutor;
                temp.pais = paisComboBoxCountrySelect.SelectedRegion.ToString();
                temp.foto = Elementos.ImageConvertions.ImageToBase64(pctPrueba.Image, ImageFormat.Jpeg);

                if (temp != null)
                {
                    ValidateAuthor validador = new ValidateAuthor();
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

                        if (mdDUsuario.AddAuthor(temp))
                        {
                            pctPrueba.Image = null;
                            fullAutorBindingSource.Clear();
                            fullAutorBindingSource.DataSource = new FullAutor();

                            if (forma!=null)
                                forma.Refresh();
                        }
                    }

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnTabla_Click(object sender, EventArgs e)
        {
            forma = new tableAuthor();
            forma.Show();
        }

        private string imgLocation;

        private void addAuthors_Load(object sender, EventArgs e)
        {
            pctPrueba.AllowDrop = true;
        }

        private void pctPrueba_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            string[] fileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            if (data != null)
            {
                var filename = data as string[];

                if (filename.Length > 0)
                {
                    pctPrueba.Image = Image.FromFile((filename[0]));
                    imgLocation = fileList[0];
                    MessageBox.Show($"{imgLocation.ToString()}");
                }
            }
        }

        private void pctPrueba_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
    }
}
