using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Funcionalidad_Formularios;

namespace MainForm
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void menuPrincipal_MouseMove(object sender, MouseEventArgs e)
        {
            Funcionalidad_Formularios.Arrastre_Formularios.Llama_ReleaseCapture();
            Funcionalidad_Formularios.Arrastre_Formularios.Llama_SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void btnBooks_MouseEnter(object sender, EventArgs e)
        {
            btnBooks.ShowDropDown();
        }

        private Form FormularioAbierto = null;

        private void btnBooks_Click(object sender, EventArgs e)
        {
            
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            FormularioAbierto = FormEnPanel.AbrirForm<popularBooks>(ref pctFondo);
        }

        private void btnAgregarLibros_Click(object sender, EventArgs e)
        {
            FormularioAbierto.Hide();
            FormularioAbierto = FormEnPanel.AbrirForm<frnAddBook>(ref pctFondo);
            //FormularioAbierto.Hide();
            //Agregar_Libro frm = new Agregar_Libro();
            //frm.TopLevel = false;
            //frm.AutoScroll = true;
            //this.pctFondo.Controls.Add(frm);
            //frm.Show();
        }

        private void btnBooks_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void menuPrincipal_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void addTopicsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioAbierto = FormEnPanel.AbrirForm<frmAddTopics>(ref pctFondo);
        }
    }
}
