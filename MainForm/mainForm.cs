using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Elementos;
using Funcionalidad_Formularios;

namespace MainForm
{
    public partial class frmPrincipal : Form
    {
        private TipoUsuario.NivelAutorizacion currentAutorizacion = TipoUsuario.NivelAutorizacion.Invitado;

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
                        {opc.Visible = true;}

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

        private Form FormularioAbierto = null;


        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            FormularioAbierto = FormEnPanel.AbrirForm<popularBooks>(ref pctFondo);
        }

        private void btnAgregarLibros_Click(object sender, EventArgs e)
        {
            FormularioAbierto = FormEnPanel.AbrirForm<frnAddBook>(ref pctFondo);
        }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {
            if (currentAutorizacion == TipoUsuario.NivelAutorizacion.Invitado)
            {
                using (Login.Login logg = new Login.Login())
                {
                    logg.StartPosition = FormStartPosition.CenterParent;
                    DialogResult dr = logg.ShowDialog();

                    if (dr == DialogResult.OK & logg.Auth != TipoUsuario.NivelAutorizacion.Invitado)
                    {
                        MessageBox.Show($"{logg.Auth}");
                        this.currentAutorizacion = logg.Auth;
                        DeterminComponents();
                    }
                }
            }
        }

        private void manageTopicsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioAbierto = FormEnPanel.AbrirForm<frmAddTopics>(ref pctFondo);
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
            FormularioAbierto = FormEnPanel.AbrirForm<searchBooks>(ref pctFondo);
        }
    }
}
