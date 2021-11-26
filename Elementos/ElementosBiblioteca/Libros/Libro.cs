using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elementos.ElementosBiblioteca.Autor;

namespace Elementos
{
    /// <summary>
    /// Clase que hereda de LibroSencillo, esta clase es utilizada para obtener TODOS los datos del Libro.
    /// </summary>
    public class Libro : LibroSencillo
    {
        public List<Tema> listaTemas;
        public List<AutorSimple> listaAutores;
        
        //Codigo, titulo, Descripcion, Imagen

        /// <summary>
        /// ISBN del libro, Longitud(15)
        /// </summary>
        public string ISBN { get; set; }

        /// <summary>
        /// Codigo de la editorial del libro, Longitud(5)
        /// </summary>
        public string codEditorial { get; set; }

        /// <summary>
        /// Numero de edicion del libro.
        /// </summary>
        public int numEdicion { get; set; }

        /// <summary>
        /// Cantidad de copias existentes.
        /// </summary>
        public int Copias { get; set; }

        /// <summary>
        /// Año de edicion del libro
        /// </summary>
        public int AñoEdicion { get; set; }
        
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Libro() { }

        public Libro(LibroSencillo param)
        {



            this.Codigo = param.Codigo;
            this.Titulo = param.Titulo;
            this.Imagen = param.Imagen;
            this.Descripcion = param.Descripcion;
        }

        ~Libro() { }
    }
}

