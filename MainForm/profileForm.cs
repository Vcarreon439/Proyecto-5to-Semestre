using System.Drawing;
using System.Windows.Forms;
using Elementos;

namespace MainForm
{
    public partial class profileForm : Form
    {

        public profileForm(FullUser usuario)
        {
            InitializeComponent();
            pctImagenUsuario.AllowDrop = true;
            loadExternalData(usuario);
        }

        private void loadExternalData(FullUser usuario)
        {
            this.nombreTextBox.Text = usuario.Nombre;
            this.apellidosTextBox.Text = usuario.Apellidos;
            this.entidadTextBox.Text = usuario.Entidad;
            this.domicilioTextBox.Text = usuario.Domicilio;
            this.correoTextBox.Text = usuario.Correo;
            this.situacionLabel1.Text = usuario.Situacion;

            switch (usuario.Genero)
            {
                case "Masculino":
                    this.generoComboBox.SelectedIndex = 0;
                    break;
                case "Femenino":
                    this.generoComboBox.SelectedIndex = 1;
                    break;
                default:
                    this.generoComboBox.SelectedIndex = 2;
                    break;
            }

            this.fechaDateTimeDateTimePicker.Value = usuario.FechaDateTime;
            this.pctImagenUsuario.Image = ImageConvertions.Base64ToImage(usuario.ImagenUsuario);
        }

        private void pctImagenUsuario_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            string[] fileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            if (data != null)
            {
                var filename = data as string[];

                if (filename.Length > 0)
                {
                    pctImagenUsuario.Image = Image.FromFile((filename[0]));
                    imgLocation = fileList[0];
                    MessageBox.Show($"{imgLocation.ToString()}");
                }
            }
        }
        
        private string imgLocation;


        private void pctImagenUsuario_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void btnCambiarFoto_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pctImagenUsuario.Image = new Bitmap(open.FileName);
                imgLocation = open.FileName;
            }
        }

        private void btnGuardar_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Desea guardar los cambios?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
