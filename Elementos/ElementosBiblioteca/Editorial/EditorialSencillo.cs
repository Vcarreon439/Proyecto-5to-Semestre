using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elementos
{
    /// <summary>
    /// Clase EditorialSencillo, utilizada para mostrar las editoriales al usuario
    /// </summary>
    public class EditorialSencillo
    {
        /// <summary>
        /// Codigo de la editorial, Longitud(5)
        /// </summary>
        public string Codigo { get; set; }

        /// <summary>
        /// Nombre de la editorial, Longitud(50)
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public EditorialSencillo() { }

        public EditorialSencillo(string codigo, string nombre)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
        }

        ~EditorialSencillo() { }

    }
}
