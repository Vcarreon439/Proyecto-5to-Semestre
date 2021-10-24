using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elementos
{
    /// <summary>
    /// Clase Tema, utilizada para validar parcialmente las operaciones realizadas en este contexto.
    /// </summary>
    public class Tema
    {
        /// <summary>
        /// Codigo del tema Longitud(5)
        /// </summary>
        public string Codigo { get; set; }

        /// <summary>
        /// El tema en si.
        /// </summary>
        public string Descripcion { get; set; }

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Tema() { }

        /// <summary>
        /// Establece los valores de "Codigo" y de "Descripcion"
        /// </summary>
        /// <param name="cod">Codigo del tema</param>
        /// <param name="descripcion">El tema</param>
        public Tema(string cod, string descripcion)
        {
            this.Codigo = cod;
            this.Descripcion = descripcion;
        }

        ~Tema() { }
    }
}
