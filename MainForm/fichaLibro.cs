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

        private void Fill()
        {
            this.lblTitulo.Text = libroFicha.Titulo;
            this.lblISBN.Text = libroFicha.ISBN;
            this.lblNumEdicion.Text = libroFicha.numEdicion.ToString();
            this.lblAñoEdicion.Text = libroFicha.añoEdicion.ToString();
            this.lblDescripcion.Text = libroFicha.descripcion;
            this.lblTitulo.Text = libroFicha.Titulo;
            this.pictureBox1.Image = ImageConvertions.Base64ToImage(libroFicha.imagenLibro);

        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
