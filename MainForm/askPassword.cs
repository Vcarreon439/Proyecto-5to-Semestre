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
    public partial class askPassword : Form
    {
        private int codigoUsuario;
        public int CodigoUsuario => codigoUsuario;

        private FullUser intern;

        public askPassword(FullUser usuario)
        {
            InitializeComponent();
            this.intern = usuario;
        }

        

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text=="")
                return;

            ModeloDUsuario obj = new ModeloDUsuario();
            codigoUsuario = obj.GetUserCode(this.intern.Correo, txtContraseña.Text);
            this.DialogResult = DialogResult.Yes;
        }
    }
}
