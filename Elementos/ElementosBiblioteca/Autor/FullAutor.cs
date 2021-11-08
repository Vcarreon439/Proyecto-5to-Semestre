using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elementos.ElementosBiblioteca.Autor
{
    public class FullAutor : AutorSimple
    {
        public string pais { get; set; }
        public string ciudad { get; set; }
        public string comentarios { get; set; }
        public string foto { get; set; }

        public FullAutor(string codigo) : base(codigo)
        {
            this._codigo = codigo;
        }

        public FullAutor()
        {

        }
    }
}
