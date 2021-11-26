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

namespace MainForm
{
    public partial class fichaLibro : Form
    {
        private Libro libroFicha;

        public fichaLibro()
        {
            InitializeComponent();
        }

        public fichaLibro(LibroSencillo libro)
        {
            InitializeComponent();
            

        }

        private Libro GetBookView(LibroSencillo lib)
        {
            ModeloDUsuario obj = new ModeloDUsuario();
            Libro param = obj.GetBookView(string codigo);
            this.lblTitulo.Text = param.Titulo;
            this.lblISBN.Text = param.ISBN;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
