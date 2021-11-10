using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login.Properties;

namespace Login
{
    public partial class Success : Form
    {
        public Success(bool resultado)
        {
            InitializeComponent();

            switch (resultado)
            {
                case true:
                    this.pctImage.Image = Resources.check_3x;
                    this.pctImage.BorderColor = Color.FromArgb(0, 192, 0);
                    this.pctImage.BorderColor2 = Color.FromArgb(0, 192, 0);
                    break;

                case false:
                    this.pctImage.Image = Resources.settings;
                    this.pctImage.BorderColor = Color.Red;
                    this.pctImage.BorderColor2 = Color.Red;
                    break;
            }

        }

        private void rounded_Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            Funcionalidad_Formularios.Arrastre_Formularios.Llama_ReleaseCapture();
            Funcionalidad_Formularios.Arrastre_Formularios.Llama_SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
