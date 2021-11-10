using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Elementos;
using Elementos.ElementosBiblioteca.Autor;

namespace MainForm.Auxiliares
{
    public class ListasObjetos
    {
        public List<EditorialSencillo> Editoriales;
        public List<Tema> Temas;
        public List<AutorSimple> Autores;

        public ListasObjetos()
        {
            Editoriales = new List<EditorialSencillo>();
            Temas = new List<Tema>();
            Autores = new List<AutorSimple>();
        }

        public static void LoadEditoriales(ref List<EditorialSencillo> listaEditoriales)
        {
            ModeloDUsuario objDUsuario = new ModeloDUsuario();
            listaEditoriales = objDUsuario.LoadEditoriales();
        }

        public static void LoadTemas(ref List<Tema> listaTemas)
        {
            ModeloDUsuario objDUsuario = new ModeloDUsuario();
            listaTemas = objDUsuario.LoadTemas();
        }

        public static void LoadAutores(ref List<AutorSimple> listaAutores)
        {
            ModeloDUsuario objDUsuario = new ModeloDUsuario();
            listaAutores = objDUsuario.LoadAutores();
        }
    }
}
