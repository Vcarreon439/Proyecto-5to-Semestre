using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Elementos;

namespace Login
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (VerificarCampos() & VerificarContraseñas())
            {
                ModeloDUsuario mdDUsuario = new ModeloDUsuario();
                UsuarioTemp obj = new UsuarioTemp();
                obj.Nombre = txtFirstName.Text;
                obj.Apellidos = txtSecondName.Text;
                obj.Correo = txtMail.Text;
                obj.Contraseña = txtPassword.Text;

                Success frm = new Success(mdDUsuario.NewUser(obj));
                frm.ShowDialog();
            }
        }

        private bool VerificarContraseñas()
        {
            if (txtPassword.Text != txtConfirm.Text)
            {
                txtPassword.StateCommon.Border.Color1 = Color.Red;
                txtConfirm.StateCommon.Border.Color1 = Color.Red;
                return false;
            }
            else
            {
                txtPassword.StateCommon.Border.Color1 = Color.Gray;
                txtConfirm.StateCommon.Border.Color1 = Color.Gray;
                return true;
            }
        }

        private bool VerificarCampos()
        {
            if (txtFirstName.Text=="")
                return false;

            if (txtSecondName.Text=="")
                return false;

            if (txtMail.Text == "")
                return false;

            if (txtPassword.Text == "")
                return false;

            if (txtConfirm.Text == "")
                return false;

            return true;
        }

        

        private void rounded_Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            Funcionalidad_Formularios.Arrastre_Formularios.Llama_ReleaseCapture();
            Funcionalidad_Formularios.Arrastre_Formularios.Llama_SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #region Eventos_Enter

        private bool name = false;
        private void txtFirstName_Enter(object sender, EventArgs e)
        {
            if (!name)
                this.txtFirstName.Text = "";
            else
                name = true;
        }

        private bool secondname = false;
        private void txtSecondName_Enter(object sender, EventArgs e)
        {
            if (!secondname)
                this.txtSecondName.Text = "";
            else
                secondname = true;
        }

        private bool mail = false;
        private void txtMail_Enter(object sender, EventArgs e)
        {
            if (!mail)
                this.txtMail.Text = "";
            else
                mail = true;
        }

        private bool pass = false;
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            this.txtPassword.StateCommon.Border.Color1 = Color.Gray;

            if (!pass)
                this.txtPassword.Text = "";
            else
                pass = true;
        }

        private bool Spass = false;
        private void txtConfirm_Enter(object sender, EventArgs e)
        {
            this.txtConfirm.StateCommon.Border.Color1 = Color.Gray;

            if (!Spass)
                this.txtConfirm.Text = "";
            else
                Spass = true;
        }

        #endregion

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            name = true;
        }

        private void txtSecondName_TextChanged(object sender, EventArgs e)
        {
            secondname = true;
        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {
            mail = true;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            pass = true;
            this.txtPassword.PasswordChar = '•';
        }

        private void txtConfirm_TextChanged(object sender, EventArgs e)
        {
            Spass = true;
            this.txtConfirm.PasswordChar = '•';
        }
    }
}
