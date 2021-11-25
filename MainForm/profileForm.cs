using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Elementos;

namespace MainForm
{
    public partial class profileForm : Form
    {

        public profileForm(FullUser usuario)
        {
            InitializeComponent();
            loadExternalData(usuario);
        }

        private void loadExternalData(FullUser usuario)
        {
            this.nombreTextBox.Text = usuario.Nombre;
            this.apellidosTextBox.Text = usuario.Apellidos;
            this.entidadTextBox.Text = usuario.Entidad;

            if (usuario.Genero==""|usuario==null)
                this.generoComboBox.SelectedIndex = 2;
        }
    }
}
