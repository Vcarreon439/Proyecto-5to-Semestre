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
using Elementos.ElementosBiblioteca.Autor;

namespace MainForm
{
    public partial class tableAuthor : Form
    {
        private FullAutor selectedAuthor;


        public tableAuthor()
        {
            InitializeComponent();
            dgvAutor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dgvAutor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAutor.SelectedCells[0].Value==null)
                return;

            using (fichaAutor ficha = new fichaAutor(GenerateAutor(dgvAutor.SelectedCells)))
            {
                DialogResult dr = ficha.ShowDialog();

                if (dr==DialogResult.Yes)
                    Refresh();

                if (dr == DialogResult.No)
                    Refresh();
            }
        }

        private FullAutor GenerateAutor(DataGridViewSelectedCellCollection selected)
        {
            if (selected[0].Value==null)
                return null;

            FullAutor autor = new FullAutor(selected[0].Value.ToString());
            autor.Nombre = selected[1].Value.ToString();
            autor.Apellido = selected[2].Value.ToString();
            autor.pais = selected[3].Value.ToString();
            autor.ciudad = selected[4].Value.ToString();

            ModeloDUsuario obj = new ModeloDUsuario();
            DataTable temp = obj.TakeExtraDataAutor(autor.Codigo);

            autor.comentarios = temp.Rows[0][0].ToString();
            autor.foto = temp.Rows[0][1].ToString();

            return autor;
        }


        public void Refresh()
        {
            dgvAutor.DataSource = null;
            dgvAutor.Rows.Clear();
            FillData();
        }

        private void pnlEncabezado_MouseMove(object sender, MouseEventArgs e)
        {
            Funcionalidad_Formularios.Arrastre_Formularios.Llama_ReleaseCapture();
            Funcionalidad_Formularios.Arrastre_Formularios.Llama_SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void tableAuthor_Load(object sender, EventArgs e)
        {
            FillData();
        }

        private void FillData()
        {
            try
            {
                ModeloDUsuario Obj = new ModeloDUsuario();
                
                foreach (DataRow row in Obj.AutoresTabla().Rows)
                    dgvAutor.Rows.Add(row[0], row[1], row[2], row[3], row[4]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
