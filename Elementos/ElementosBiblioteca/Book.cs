using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elementos
{
    public class Book
    {
        public string ISBN { get; set; }
        public string Titulo { get; set; }
        public string codEditorial { get; set; }
        public int numEdicion { get; set; }
        public int Copias { get; set; }
        public string AñoEdicion { get; set; }
        public string Imagen { get; set; }
        public string Descripcion { get; set; }


        public Book() { }

        ~Book() { }
    }
}

