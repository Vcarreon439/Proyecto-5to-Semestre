using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elementos
{
    /// <summary>
    /// Clase LibroSencillo, utilizada para mostrar libros al usuario
    /// </summary>
    public class LibroSencillo
    {
        /// <summary>
        /// Codigo del libro
        /// </summary>
        public int Codigo { get; set; }

        /// <summary>
        /// Titulo del libro
        /// </summary>
        public string Titulo { get; set; }

        /// <summary>
        /// Deescripción del libro
        /// </summary>
        public string Descripcion { get; set; }

        /// <summary>
        /// Imagen en formato cadena del libro
        /// </summary>
        public string Imagen { get; set; }

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public LibroSencillo() { }
    }
}
