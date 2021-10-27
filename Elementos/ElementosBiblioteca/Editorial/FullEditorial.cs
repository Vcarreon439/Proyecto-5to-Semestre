using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elementos.ElementosBiblioteca.Editorial
{
    public class FullEditorial : EditorialSencillo
    {
        public string Codigo { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }

        public FullEditorial(FullEditorial senderEditorial)
        {
            this.Codigo = senderEditorial.Codigo;
            this.Correo = senderEditorial.Correo;
            this.Direccion = senderEditorial.Direccion;
            this.Telefono = senderEditorial.Telefono;
            this.Nombre = senderEditorial.Nombre;
        }

        public FullEditorial(){}

        public FullEditorial(DataGridViewSelectedCellCollection SelectedCells)
        {
            this.Codigo = SelectedCells[0].Value.ToString();
            this.Nombre = SelectedCells[1].Value.ToString();
            this.Telefono= SelectedCells[2].Value.ToString();
            this.Correo = SelectedCells[3].Value.ToString();
            this.Direccion = SelectedCells[4].Value.ToString();
        }
    }
}
