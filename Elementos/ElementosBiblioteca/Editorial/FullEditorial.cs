using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elementos.ElementosBiblioteca.Editorial
{
    /// <summary>
    /// Clase que hereda de EditorialSencillo, esta clase es utilizada para obtener TODOS los datos de una Editorial.
    /// </summary>
    public class FullEditorial : EditorialSencillo
    {
        /// <summary>
        /// Codigo de la editorial
        /// </summary>
        public string Codigo { get; set; }

        /// <summary>
        /// Telefono de la editorial
        /// </summary>
        public string Telefono { get; set; }

        /// <summary>
        /// Correo de la editorial
        /// </summary>
        public string Correo { get; set; }

        /// <summary>
        /// Direccion de la editorial
        /// </summary>
        public string Direccion { get; set; }

        /// <summary>
        /// Clase en caso de contar con un FullEditorial
        /// </summary>
        /// <param name="senderEditorial">Origen del cual se pasaran los datos</param>
        public FullEditorial(FullEditorial senderEditorial)
        {
            this.Codigo = senderEditorial.Codigo;
            this.Correo = senderEditorial.Correo;
            this.Direccion = senderEditorial.Direccion;
            this.Telefono = senderEditorial.Telefono;
            this.Nombre = senderEditorial.Nombre;
        }

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public FullEditorial(){}

        /// <summary>
        /// Crear un FullEditorial en caso de tener Celdas seleccionadas de un DataGridView
        /// [0] para Codigo, [1] para Nombre, [2] para Telefono, [3] para Correo, [4] para Direccion
        /// </summary>
        /// <param name="SelectedCells"></param>
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
