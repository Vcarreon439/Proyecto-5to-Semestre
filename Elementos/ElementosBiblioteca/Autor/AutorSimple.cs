using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elementos.ElementosBiblioteca.Autor
{
    /// <summary>
    /// 
    /// </summary>
    public class AutorSimple
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public string Codigo => _codigo;

        protected string _codigo;

        public AutorSimple(string codigo)
        {
            this._codigo = codigo;
        }

        public AutorSimple(string codigo, string nombre, string apellido)
        {
            this._codigo = codigo;
            this.Nombre = nombre;
            this.Apellido = apellido;
        }

        public AutorSimple()
        {

        }
    }
}
