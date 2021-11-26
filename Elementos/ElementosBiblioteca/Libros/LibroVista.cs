using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elementos.ElementosBiblioteca.Libros
{
    public class LibroVista
    {
        private int _codigo;
        public string Titulo { get; set; }
        public string ISBN { get; set; }
        public string Editorial { get; set; }
        public int numEdicion { get; set; }
        public int añoEdicion { get; set; }
        public string imagenLibro { get; set; }

        public string descripcion { get; set; }

        public int Codigo => _codigo;

        public LibroVista(int codigo)
        {
            this._codigo = codigo;
        }
    }
}
