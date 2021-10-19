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

namespace MainForm
{
    public partial class frmAddTopics : Form
    {
        public frmAddTopics()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigo.Text!="" && txtDescripcion.Text!="")
                {
                    ModeloDUsuario obj = new ModeloDUsuario();
                    Tema tema = new Tema();
                    tema.Codigo = txtCodigo.Text;
                    tema.Nombre = txtDescripcion.Text;

                    obj.AddTema(tema);

                    txtCodigo.Text = "";
                    txtDescripcion.Text = "";

                    FillData();
                }
                else
                {
                    MessageBox.Show("Los campos codigo y descripcion no pueden ir vacios", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }

        private void FillData()
        {
            try
            {
                ModeloDUsuario Obj = new ModeloDUsuario();
                dgvGeneros.DataSource = Obj.MostrarGeneros50();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }

        private void frmAddTopics_Load(object sender, EventArgs e)
        {
            FillData();
        }
    }
}
