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
using FluentValidation.Results;

namespace Login
{
    public partial class Login : Form
    {
        protected string mailtxt;

        private TipoUsuario.NivelAutorizacion auth;
        public TipoUsuario.NivelAutorizacion Auth => auth;

        public Login()
        {
            InitializeComponent();
            userAccesBindingSource.DataSource = new UserAcces();
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
            this.DialogResult = DialogResult.Cancel;
            this.Close();
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
            try
            {
                userAccesBindingSource.EndEdit();
                UserAcces user = userAccesBindingSource.Current as UserAcces;

                if (user != null)
                {
                    ValidarAcceso validador = new ValidarAcceso();
                    ValidationResult resultado = validador.Validate(user);
                    IList<ValidationFailure> fallas = resultado.Errors;

                    if (!resultado.IsValid)
                    {
                        foreach (ValidationFailure errors in fallas)
                        {
                            MessageBox.Show(errors.ErrorMessage, errors.PropertyName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                    }
                    else
                    {
                        ModeloDUsuario mdDUsuario = new ModeloDUsuario();
                        string newPass = Encriptado.Encrypt(user.Contraseña);
                        user.Contraseña = newPass;
                        this.auth = mdDUsuario.LoginUser(user);

                        switch (auth)
                        {
                            case TipoUsuario.NivelAutorizacion.Master:
                                this.DialogResult = DialogResult.OK;
                                break;

                            case TipoUsuario.NivelAutorizacion.Admin:
                                this.DialogResult = DialogResult.OK;
                                break;

                            case TipoUsuario.NivelAutorizacion.User:
                                this.DialogResult = DialogResult.OK;
                                break;

                            case TipoUsuario.NivelAutorizacion.Invitado:
                                MessageBox.Show("El correo o la contraseña son incorrectas");
                                break;
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                return;
            }
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
