using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elementos.ElementosBiblioteca.Autor
{
    public class FullAutor : AutorSimple
    {
        private string _codigo;
        public string pais { get; set; }
        public string ciudad { get; set; }
        public string comentarios { get; set; }
        public string foto { get; set; }
        public string Codigo => _codigo;

        public FullAutor(string codigo)
        {
            this._codigo = codigo;
        }

        public FullAutor()
        {

        }


    }
}
