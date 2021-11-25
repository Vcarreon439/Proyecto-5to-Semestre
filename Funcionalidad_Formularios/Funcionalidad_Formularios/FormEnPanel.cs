using System;
using System.Linq;
using System.Windows.Forms;

namespace Funcionalidad_Formularios
{
    public class FormEnPanel
    {
        static public Form AbrirForm<MiForm>(ref PictureBox pnlFormularios) where MiForm : Form, new()
        {
            Form formulario;
            formulario = pnlFormularios.Controls.OfType<MiForm>().FirstOrDefault(); //Busca formulario en coleccion
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                pnlFormularios.Controls.Add(formulario);
                pnlFormularios.Tag = formulario;
                formulario.Show();
                return formulario;
            }
            //En caso de ya estar abierto
            else
            {
                formulario.BringToFront();
                formulario.WindowState = FormWindowState.Maximized;
                return null;
            }
        }

        static public Form AbrirFormulario<T>(ref PictureBox pnlFormularios, Func <T> metodofactory) where T : Form
        {
            Form formulario = pnlFormularios.Controls.OfType<T>().FirstOrDefault();

            //Buscar el formulario dentro del panel.
            if (formulario != null)
            {
                formulario.BringToFront();
                formulario.WindowState = FormWindowState.Maximized;

                
            }

            formulario = metodofactory();
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            pnlFormularios.Controls.Add(formulario);
            pnlFormularios.Tag = formulario;
            formulario.Show();
            return formulario;
        }

        static public DialogResult AbrirForm<MiFomr>(ref PictureBox pnlFormularios, int valor=0) where MiFomr : Form, new()
        {
            Form formulario;
            formulario = pnlFormularios.Controls.OfType<MiFomr>().FirstOrDefault(); //Busca formulario en coleccion
            if (formulario == null)
            {
                formulario = new MiFomr();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                pnlFormularios.Controls.Add(formulario);
                pnlFormularios.Tag = formulario;
                formulario.Show();
            }
            //En caso de ya estar abierto
            else
            {
                formulario.BringToFront();
                formulario.WindowState = FormWindowState.Maximized;
            }

            return formulario.DialogResult;
        }

    }
}
