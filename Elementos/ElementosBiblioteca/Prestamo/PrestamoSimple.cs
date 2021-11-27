using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elementos.ElementosBiblioteca.Prestamo
{
    public class PrestamoSimple
    {
        private bool _generado;
        public bool Generado => _generado;

        public int numPrestamo { get; set; }

        public PrestamoSimple(bool generado)
        {
            this._generado = generado;
        }

    }
}
