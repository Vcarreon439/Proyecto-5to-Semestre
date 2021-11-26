using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Elementos;
using Elementos.ElementosBiblioteca.Libros;
using MainForm.Properties;

namespace MainForm
{
    public partial class popularBooks : Form
    {
        private List<LibroSencillo> listaLibros;
        private frmPrincipal forma;

        public popularBooks(frmPrincipal forma)
        {
            InitializeComponent();
            this.forma = forma;
        }

        private void popularBooks_Load(object sender, EventArgs e)
        {
            ModeloDUsuario mdDUsuario = new ModeloDUsuario();
            listaLibros = mdDUsuario.LibrosPopulares_4();
            CargarLibros(listaLibros);
        }

        private void CargarPortada(ref PictureBox caja, ref Label Titulo, ref Label Descripcion, LibroSencillo libro = null)
        {
            if (libro.Imagen == "")
                caja.Image = Resources.ImageNotAvalible;
            else
                caja.Image = ImageConvertions.Base64ToImage(libro.Imagen);

            Titulo.Text = libro.Titulo;

            Descripcion.Text = libro.Descripcion;
        }

        private void CargarLibros(List<LibroSencillo> listaLibros)
        {
            if (listaLibros == null)
                return;

            for (int i = 0; i < listaLibros.Count; i++)
            {
                switch (i)
                {
                    case 0:
                        CargarPortada(ref pctRecomendado1, ref lblLibro1, ref lblDescripcionL1, listaLibros[i]);
                        break;

                    case 1:
                        CargarPortada(ref pctRecomendado2, ref lblLibro2, ref lblDescripcionL2, listaLibros[i]);
                        break;

                    case 2:
                        CargarPortada(ref pctRecomendado3, ref lblLibro3, ref lblDescripcionL3, listaLibros[i]);
                        break;

                    case 3:
                        CargarPortada(ref pctRecomendado4, ref lblLibro4, ref lblDescripcionL4, listaLibros[i]);
                        break;
                }
            }

        }
    

        private void popularBooks_MouseMove(object sender, MouseEventArgs e)
        {
            Funcionalidad_Formularios.Arrastre_Formularios.Llama_ReleaseCapture();
            Funcionalidad_Formularios.Arrastre_Formularios.Llama_SendMessage(ParentForm.Handle, 0x112, 0xf012, 0);
        }

        private void LayoutPopulares_MouseMove(object sender, MouseEventArgs e)
        {
            Funcionalidad_Formularios.Arrastre_Formularios.Llama_ReleaseCapture();
            Funcionalidad_Formularios.Arrastre_Formularios.Llama_SendMessage(ParentForm.Handle, 0x112, 0xf012, 0);
        }

        private void pctRecomendado1_Click(object sender, EventArgs e)
        {
            if(listaLibros[0]==null)
                return;

            ModeloDUsuario obj = new ModeloDUsuario();
            fichaLibro libro = new fichaLibro(obj.GetBookView(listaLibros[0].Codigo));

            if (libro.ShowDialog()==DialogResult.Yes)
            {
                forma.librosRenta.Add(libro.LibroFicha);
            }
        }

        private void pctRecomendado2_Click(object sender, EventArgs e)
        {
            if (listaLibros.Count  < 2)
                return;

            ModeloDUsuario obj = new ModeloDUsuario();
            fichaLibro libro = new fichaLibro(obj.GetBookView(listaLibros[1].Codigo));

            if (libro.ShowDialog() == DialogResult.Yes)
            {
                forma.librosRenta.Add(libro.LibroFicha);
            }
        }

        private void pctRecomendado3_Click(object sender, EventArgs e)
        {
            if (listaLibros.Count < 3)
                return;

            ModeloDUsuario obj = new ModeloDUsuario();
            fichaLibro libro = new fichaLibro(obj.GetBookView(listaLibros[2].Codigo));

            if (libro.ShowDialog() == DialogResult.Yes)
            {
                forma.librosRenta.Add(libro.LibroFicha);
            }
        }

        private void pctRecomendado4_Click(object sender, EventArgs e)
        {
            if (listaLibros.Count < 4)
                return;

            ModeloDUsuario obj = new ModeloDUsuario();
            fichaLibro libro = new fichaLibro(obj.GetBookView(listaLibros[3].Codigo));

            if (libro.ShowDialog() == DialogResult.Yes)
            {
                forma.librosRenta.Add(libro.LibroFicha);
            }
        }

    }
}
