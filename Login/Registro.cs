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
            ModeloDUsuario mdDUsuario = new ModeloDUsuario();
            UsuarioTemp obj = new UsuarioTemp();
            obj.Nombre = txtFirstName.Text;
            obj.Apellidos = txtSecondName.Text;
            obj.Correo = txtMail.Text;
            obj.Contraseña = txtPassword.Text;
            
            if (mdDUsuario.RegisterNew(obj))
            {
                Success frm = new Success();
                frm.ShowDialog();
            }

            
        }

        private void txtFirstName_Enter(object sender, EventArgs e)
        {

        }
    }
}
