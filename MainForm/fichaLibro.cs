using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Elementos;
using Elementos.ElementosBiblioteca.Libros;

namespace MainForm
{
    public partial class fichaLibro : Form
    {
        private LibroVista libroFicha;

        public fichaLibro()
        {
            InitializeComponent();
        }

        public fichaLibro(LibroVista libro)
        {
            InitializeComponent();
            this.libroFicha = libro;
            Fill();
        }

        public LibroVista LibroFicha => libroFicha;

        private void Fill()
        {
            this.lblTitulo.Text = LibroFicha.Titulo;

            if (LibroFicha.ISBN!="")
                this.lblISBN.Text = LibroFicha.ISBN;

            this.lblEditorial.Text = LibroFicha.Editorial;
            this.lblNumEdicion.Text = LibroFicha.numEdicion.ToString();
            this.lblAñoEdicion.Text = LibroFicha.añoEdicion.ToString();
            this.lblDescripcion.Text = LibroFicha.descripcion;
            this.lblTitulo.Text = LibroFicha.Titulo;
            this.pictureBox1.Image = ImageConvertions.Base64ToImage(LibroFicha.imagenLibro);
            this.TopMost = true;
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRentar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea rentar este libro?", "",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.DialogResult = DialogResult.Yes;
            else
                this.DialogResult = DialogResult.No;
        }
    }
}
