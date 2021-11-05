using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Elementos.ElementosBiblioteca.Autor;
using Elementos.ElementosBiblioteca.Editorial;
using FluentValidation.Results;
using MainForm.ValidateData;

namespace MainForm
{
    public partial class fichaAutor : Form
    {
        private FullAutor updateAutor;

        public fichaAutor(FullAutor fullAutor)
        {
            InitializeComponent();

            fullAutorBindingSource.DataSource = fullAutor;
            paisComboBoxCountrySelect.SelectedRegion = new RegionInfo(fullAutor.pais);
            rjCircularPictureBox1.Image = Elementos.ImageConvertions.Base64ToImage(fullAutor.foto);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                fullAutorBindingSource.EndEdit();
                updateAutor = fullAutorBindingSource.Current as FullAutor;
                updateAutor.pais = paisComboBoxCountrySelect.SelectedRegion.ToString();

                if (updateAutor != null)
                {
                    ValidateAuthor validador = new ValidateAuthor();
                    ValidationResult resultado = validador.Validate(updateAutor);
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

                        if (mdDUsuario.UpdateAutor(updateAutor))
                        {
                            MessageBox.Show("Cambios realizados correctamente");
                            this.Close();
                        }
                    }

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                fullAutorBindingSource.EndEdit();
                updateAutor = fullAutorBindingSource.Current as FullAutor;

                if (updateAutor != null)
                {
                    ValidateAuthor validador = new ValidateAuthor();
                    ValidationResult resultado = validador.Validate(updateAutor);
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

                        if (mdDUsuario.DeleteAutor(updateAutor.Codigo))
                        {
                            MessageBox.Show($"Se ha eliminado al autor {updateAutor.Nombre}");
                            this.Close();
                        }
                    }

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
