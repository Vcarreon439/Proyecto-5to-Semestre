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
using Dominio;
using Elementos;
using Elementos.ElementosBiblioteca.Libros;

namespace MainForm
{
    public partial class rentarLibro : Form
    {
        private frmPrincipal local;
        private ModeloDUsuario modeloD = new ModeloDUsuario();

        public rentarLibro(frmPrincipal formaprincipal)
        {
            InitializeComponent();
            this.local = formaprincipal;
            ActualizarContenido();
            
            label1.Text = DateTime.Now.ToString();
            timerReloj.Start();
            timer1.Start();
        }

        public void ActualizarContenido()
        {
            dataGridView1.Rows.Clear();

            foreach (LibroVista libro in local.librosRenta)
            {
                string temas ="";
                
                foreach (Tema tema in modeloD.GetBookTopics(libro.Codigo))
                    temas += " " + tema.Descripcion;

                dataGridView1.Rows.Add(libro.Titulo, libro.Editorial, temas);
            }
        }

        private void timerReloj_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ActualizarContenido();
        }
    }
}
