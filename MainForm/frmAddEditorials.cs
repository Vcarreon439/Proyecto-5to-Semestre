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

        private void dgvEditoriales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectEditorial = new FullEditorial(dgvEditoriales.SelectedCells);
            fullEditorialBindingSource.DataSource = new FullEditorial(dgvEditoriales.SelectedCells);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
    }
}
