using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomControls.CheckBoxComboBox;
using Elementos;
using MainForm.Auxiliares;

namespace MainForm
{
    public partial class searchBooks : Form
    {
        private ListasObjetos internalList = new ListasObjetos();

        public searchBooks()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }

        private void cboTemas_Enter(object sender, EventArgs e)
        {
            ListasObjetos.LoadTemas(ref internalList.Temas);
            FillCbo(ref cboTemas, internalList.Temas);
        }

        private void FillCbo(ref CheckBoxComboBox comboBox, List<Tema> listaTemas)
        {
            comboBox.Items.Clear();

            foreach (Tema tema in listaTemas)
                comboBox.Items.Add(tema.Descripcion);
        }
    }
}
