using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomControls;
using Dominio;
using Elementos;

namespace Login
{
    public partial class Login : Form
    {
        protected string mailtxt;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {
            mailtxt = txtMail.Text;
        }

        private void lnkForget_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ResetPassword fmr = new ResetPassword(mailtxt);
            fmr.ShowDialog();
            this.Show();
        }

        private void rounded_Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            Funcionalidad_Formularios.Arrastre_Formularios.Llama_ReleaseCapture();
            Funcionalidad_Formularios.Arrastre_Formularios.Llama_SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnCerrar_MouseEnter(object sender, EventArgs e)
        {
            btnCerrar.ForeColor = Color.LightGray;
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.ForeColor = Color.FromArgb(192, 0, 0);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ModeloDUsuario mdDUsuario = new ModeloDUsuario();
            UsuarioTemp obj = new UsuarioTemp();
            obj.Correo = txtMail.Text;
            obj.Contraseña = txtPassword.Text;
            FullUser result = mdDUsuario.Login(obj);
            
            if (result == null)
            {
                    
            }
            

            this.DialogResult = DialogResult.OK;
            MessageBox.Show("");
        }

        private void lnkSignUp_LinkClicked(object sender, EventArgs e)
        {
            this.Hide();
            Registro frm = new Registro();
            frm.ShowDialog();
            this.Show();
        }

        private void rounded_Panel1_Move(object sender, EventArgs e)
        {
            Funcionalidad_Formularios.Arrastre_Formularios.Llama_ReleaseCapture();

        }
    }
}
