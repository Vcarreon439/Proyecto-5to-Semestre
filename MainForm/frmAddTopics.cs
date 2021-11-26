using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Elementos;
using FluentValidation.Results;
using MainForm.ValidateData;

namespace MainForm
{
    public partial class frmAddTopics : Form
    {
        private Tema selectedTema;
        private Tema updatedTema;
        private bool isSelected = false;

        public frmAddTopics()
        {
            InitializeComponent();
            dgvGeneros.AllowUserToAddRows = false;
            dgvGeneros.AllowUserToDeleteRows = false;
            dgvGeneros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            temaBindingSource.DataSource = new Tema();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                temaBindingSource.EndEdit();
                Tema topic = temaBindingSource.Current as Tema;

                if (topic != null)
                {
                    ValidateTopic validador = new ValidateTopic();
                    ValidationResult resultado = validador.Validate(topic);
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

                        if (mdDUsuario.AddTema(topic))
                        {
                            FillData();
                            temaBindingSource.Clear();
                            temaBindingSource.DataSource = new Tema();
                        }
                    }

                }
                else
                {
                    temaBindingSource.DataSource = new Tema();
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
                dgvGeneros.DataSource = Obj.ShowAllTopics();
                dgvGeneros.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }

        private void frmAddTopics_Load(object sender, EventArgs e)
        {
            FillData();
        }

        private void codigoKryptonTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void dgvGeneros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                temaBindingSource.EndEdit();
                updatedTema = temaBindingSource.Current as Tema;

                if (updatedTema != null)
                {
                    ValidateTopic validador = new ValidateTopic();
                    ValidationResult resultado = validador.Validate(updatedTema);
                    IList<ValidationFailure> fallas = resultado.Errors;

                    if (!resultado.IsValid)
                    {
                        foreach (ValidationFailure errors in fallas)
                        {
                            MessageBox.Show(errors.ErrorMessage, errors.PropertyName, MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    else
                    {
                        ModeloDUsuario mdDUsuario = new ModeloDUsuario();

                        if (isSelected)
                        {
                            if (mdDUsuario.UpdateTema(selectedTema, updatedTema.Codigo, updatedTema.Descripcion))
                            {
                                FillData();
                                temaBindingSource.Clear();
                                selectedTema = null;
                                updatedTema = null;
                            }
                        }
                        else
                        {
                            if (mdDUsuario.UpdateDescripcionTema(updatedTema.Codigo, updatedTema.Descripcion))
                            {
                                FillData();
                                temaBindingSource.Clear();
                                selectedTema = null;
                                updatedTema = null;
                            }
                        }
                    }
                }

                isSelected = false;
                temaBindingSource.DataSource = new Tema();
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
                temaBindingSource.EndEdit();
                Tema topic = temaBindingSource.Current as Tema;

                if (topic != null)
                {
                    ValidateTopic validador = new ValidateTopic();
                    ValidationResult resultado = validador.Validate(topic);
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

                        if (mdDUsuario.DeleteTema(topic))
                        {
                            FillData();
                            temaBindingSource.Clear();
                            temaBindingSource.DataSource = new Tema();
                        }
                    }

                }
                else
                {
                    temaBindingSource.DataSource = new Tema();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void dgvGeneros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            isSelected = true;
            selectedTema = new Tema(dgvGeneros.SelectedCells[0].Value.ToString(), dgvGeneros.SelectedCells[1].Value.ToString());
            temaBindingSource.DataSource = new Tema(dgvGeneros.SelectedCells[0].Value.ToString(), dgvGeneros.SelectedCells[1].Value.ToString());
        }
    }
}
