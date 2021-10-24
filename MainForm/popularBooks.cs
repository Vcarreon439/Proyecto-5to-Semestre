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
using MainForm.Properties;

namespace MainForm
{
    public partial class popularBooks : Form
    {
        public popularBooks()
        {
            InitializeComponent();
        }

        private List<LibroSencillo> listaLibros;

        private void popularBooks_Load(object sender, EventArgs e)
        {
            ModeloDUsuario mdDUsuario = new ModeloDUsuario();
            CargarLibros(mdDUsuario.LibrosPopulares_4());
        }

        private void CargarLibros(List<LibroSencillo> listaLibros)
        {
            if (listaLibros==null)
                return;

            Control[] imagesControls;

            for (int i = 0; i < listaLibros.Capacity; i++)
            {
                imagesControls = this.Controls.Find($"pctRecomendado{i + 1}", true);
            }

            MessageBox.Show("");

            if (listaLibros != null)
            {

                for (int i = 0; i < listaLibros.Count; i++)
                {
                    if (i == 0)
                    {
                        this.pctRecomendado1.Image = ImageConvertions.Base64ToImage(listaLibros[0].Imagen);
                        this.lblLibro1.Text = listaLibros[0].Titulo;
                    }

                    if (i == 1)
                    {
                        this.pctRecomendado2.Image = ImageConvertions.Base64ToImage(listaLibros[1].Imagen);
                        this.lblLibro2.Text = listaLibros[1].Titulo;
                    }

                    if (i == 2)
                    {
                        this.pctRecomendado3.Image = ImageConvertions.Base64ToImage(listaLibros[2].Imagen);
                        this.lblLibro3.Text = listaLibros[2].Titulo;
                    }

                    if (i == 3)
                    {
                        this.pctRecomendado4.Image = ImageConvertions.Base64ToImage(listaLibros[3].Imagen);
                        this.lblLibro4.Text = listaLibros[3].Titulo;
                    }
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
    }
}
