using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Elementos;
using Elementos.ElementosBiblioteca.Editorial;
using FluentValidation.Results;
using MainForm.ValidateData;

namespace MainForm
{
    public partial class frmAddEditorials : Form
    {
        private FullEditorial selectEditorial;
        private FullEditorial updatEditorial;
        private bool isSelected = false;

        public frmAddEditorials()
        {
            InitializeComponent();
            fullEditorialBindingSource.DataSource = new FullEditorial();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                fullEditorialBindingSource.EndEdit();
                FullEditorial publisher = fullEditorialBindingSource.Current as FullEditorial;

                if (publisher != null)
                {
                    ValidatePublisher validador = new ValidatePublisher();
                    ValidationResult resultado = validador.Validate(publisher);
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

                        if (mdDUsuario.AddEditorial(publisher))
                        {
                            FillData();
                            fullEditorialBindingSource.Clear();
                            fullEditorialBindingSource.DataSource = new FullEditorial();
                        }
                    }

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void FillData()
        {
            try
            {
                ModeloDUsuario Obj = new ModeloDUsuario();
                dgvEditoriales.DataSource = Obj.MostrarEditoriales();
                dgvEditoriales.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private void frmAddEditorials_Load(object sender, EventArgs e)
        {
            dgvEditoriales.AllowUserToAddRows = false;
            dgvEditoriales.AllowUserToDeleteRows = false;
            dgvEditoriales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            FillData();
        }

        private void dgvEditoriales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            isSelected = true;
            selectEditorial = new FullEditorial(dgvEditoriales.SelectedCells);
            fullEditorialBindingSource.DataSource = new FullEditorial(dgvEditoriales.SelectedCells);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                fullEditorialBindingSource.EndEdit();
                updatEditorial = fullEditorialBindingSource.Current as FullEditorial;

                if (updatEditorial != null)
                {
                    ValidatePublisher validador = new ValidatePublisher();
                    ValidationResult resultado = validador.Validate(updatEditorial);
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

                        if (isSelected)
                        {
                            if (mdDUsuario.UpdateEditorial(selectEditorial, updatEditorial))
                            {
                                FillData();
                                fullEditorialBindingSource.Clear();
                                selectEditorial = null;
                                updatEditorial = null;
                            }
                        }
                        else
                        {
                            if (mdDUsuario.UpdatePublishersWithotCode(updatEditorial.Codigo, updatEditorial))
                            {
                                FillData();
                                fullEditorialBindingSource.Clear();
                                selectEditorial = null;
                                updatEditorial = null;
                            }
                        }

                    }

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                fullEditorialBindingSource.EndEdit();
                FullEditorial editorial = fullEditorialBindingSource.Current as FullEditorial;

                if (editorial != null)
                {
                    ValidatePublisher validador = new ValidatePublisher();
                    ValidationResult resultado = validador.Validate(editorial);
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

                        if (mdDUsuario.DeletePublisher(editorial))
                        {
                            FillData();
                            fullEditorialBindingSource.Clear();
                            fullEditorialBindingSource.DataSource = new FullEditorial();
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
