using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Elementos;
using Elementos.ElementosBiblioteca.Libros;
using Funcionalidad_Formularios;

namespace MainForm
{
    public partial class frmPrincipal : Form
    {
        private FullUser localFullUser;
        private Form FormularioAbierto = null;
        public List<LibroVista> librosRenta = new List<LibroVista>();
        private TipoUsuario.NivelAutorizacion currentAutorizacion = TipoUsuario.NivelAutorizacion.Invitado;
        public FullUser LocalFullUser => localFullUser;

        public frmPrincipal(TipoUsuario.NivelAutorizacion recieverAutorizacion)
        {
            this.currentAutorizacion = recieverAutorizacion;
        }

        public frmPrincipal()
        {
            InitializeComponent();
            DeterminComponents();
        }

        

        private void DeterminComponents()
        {
            switch (currentAutorizacion)
            {
                case TipoUsuario.NivelAutorizacion.User:
                    this.btnReturnBooks.Visible = true;
                    this.btnIssueBooks.Visible = true;
                    break;

                case TipoUsuario.NivelAutorizacion.Admin:
                    this.btnAgregarLibros.Visible = true;
                    this.btnReturnBooks.Visible = true;
                    this.btnIssueBooks.Visible = true;
                    this.btnAdministrator.Visible = true;
                    break;

                case TipoUsuario.NivelAutorizacion.Master:
                    foreach (ToolStripMenuItem opciones in menuPrincipal.Items)
                    {
                        foreach (ToolStripMenuItem opc in opciones.DropDownItems)
                        {
                            opc.Visible = true;
                        }

                        opciones.Visible = true;
                    }

                    break;
            }
        }

        private void menuPrincipal_MouseMove(object sender, MouseEventArgs e)
        {
            Funcionalidad_Formularios.Arrastre_Formularios.Llama_ReleaseCapture();
            Funcionalidad_Formularios.Arrastre_Formularios.Llama_SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            FormularioAbierto = FormEnPanel.AbrirFormulario(ref pctFondo, () => new popularBooks(this));
        }

        private void btnAgregarLibros_Click(object sender, EventArgs e)
        {
            FormularioAbierto = FormEnPanel.AbrirForm<frnAddBook>(ref pctFondo);
        }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {
            if (currentAutorizacion == TipoUsuario.NivelAutorizacion.Invitado & LocalFullUser == null)
            {
                using (Login.Login logg = new Login.Login())
                {
                    logg.StartPosition = FormStartPosition.CenterParent;
                    DialogResult dr = logg.ShowDialog();

                    if (dr == DialogResult.OK & logg.Auth != TipoUsuario.NivelAutorizacion.Invitado)
                    {
                        MessageBox.Show($"{logg.Auth}");
                        this.currentAutorizacion = logg.Auth;
                        this.localFullUser = logg.LocalFullUser;
                        DeterminComponents();
                    }
                }
            }
            else
            {
                MessageBox.Show("Esta opcion esta en mantenimiento");
                //FormularioAbierto = FormEnPanel.AbrirFormulario(ref pctFondo, () => new profileForm(LocalFullUser));
            }
        }

        private void bookPublishersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioAbierto = FormEnPanel.AbrirForm<frmAddEditorials>(ref pctFondo);
        }

        private void authorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioAbierto = FormEnPanel.AbrirForm<addAuthors>(ref pctFondo);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnIssueBooks_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta opcion esta en mantenimiento");
            //FormularioAbierto = FormEnPanel.AbrirFormulario(ref pctFondo, () => new rentarLibro(this));
        }

        private void searchBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta opcion esta en mantenimiento");
            FormularioAbierto = FormEnPanel.AbrirForm<searchBooks>(ref pctFondo);
        }

        private void btnRentas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta opcion esta en mantenimiento");
            //FormularioAbierto = FormEnPanel.AbrirForm<manejarRentas>(ref pctFondo);
        }

        private void manageTopicsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioAbierto = FormEnPanel.AbrirForm<frmAddTopics>(ref pctFondo);
        }

        private void popularBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioAbierto = FormEnPanel.AbrirFormulario(ref pctFondo, () => new popularBooks(this));
        }

        private void manageStudentsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta opcion esta en mantenimiento");
        }

        private void btnReturnBooks_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta opcion esta en mantenimiento");
        }

        private void masterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta opcion esta en mantenimiento");
        }
    }
}
