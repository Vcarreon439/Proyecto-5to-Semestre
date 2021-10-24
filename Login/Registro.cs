using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Elementos;
using FluentValidation.Results;

namespace Login
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
            usuarioTempBindingSource.DataSource = new UsuarioTemp();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                usuarioTempBindingSource.EndEdit();
                UsuarioTemp user = usuarioTempBindingSource.Current as UsuarioTemp;

                if (user != null)
                {
                    ValidarUserTemp validador = new ValidarUserTemp();
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
                        user.Contraseña = Encriptado.Encrypt(user.Contraseña);
                        Success frm = new Success(mdDUsuario.NewUser(user));
                        frm.ShowDialog();
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                return;
            }
        }

        private void rounded_Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            Funcionalidad_Formularios.Arrastre_Formularios.Llama_ReleaseCapture();
            Funcionalidad_Formularios.Arrastre_Formularios.Llama_SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
