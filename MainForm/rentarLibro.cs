using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Elementos.ElementosBiblioteca.Libros;

namespace MainForm
{
    public partial class rentarLibro : Form
    {
        public rentarLibro(List<LibroVista> libros)
        {
            InitializeComponent();

            foreach (LibroVista libro in libros)
            {
                dataGridView1.Rows.Add(libro.Titulo, libro.Editorial);
            }

            label1.Text = DateTime.Now.ToString();
            timerReloj.Start();
            

        }

        private void ActualizarContenido()
        {


        }

        private void timerReloj_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

        private void rentarLibro_Enter(object sender, EventArgs e)
        {

        }
    }
}
