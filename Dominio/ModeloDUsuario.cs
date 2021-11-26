﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Elementos;
using Elementos.ElementosBiblioteca.Autor;
using Elementos.ElementosBiblioteca.Editorial;

namespace Dominio
{
    public class ModeloDUsuario
    {
        private Querys obj = new Querys();

        #region Users

        public bool NewUser(UsuarioTemp temp)
        {
            return obj.NewUser(temp);
        }

        public TipoUsuario.NivelAutorizacion LoginUser(UserAcces temp)
        {
            return obj.LoginUser(temp);
        }

        #endregion

        public List<LibroSencillo> LibrosPopulares_4()
        {
            return obj.LibrosPopulares_4();
        }

        public List<EditorialSencillo> Editoriales100()
        {
            return obj.Editoriales();
        }

        public bool AddBook(Libro temp)
        {
            return obj.AddBook(temp);
        }

        public bool AddTema(Tema temp)
        {
            return obj.AddTema(temp);
        }

        public bool DeleteTema(Tema temp)
        {
            return obj.DeleteTema(temp);
        }

        public DataTable ShowAllTopics()
        {
            return obj.ShowAllTopics();
        }

        public DataTable AutoresTabla()
        {
            return obj.AutoresTabla();
        }

        public DataTable TakeExtraDataAutor(string codigo)
        {
            return obj.TakeExtraDataAutor(codigo);
        }

        public bool UpdateAutor(FullAutor autor)
        {
            return obj.UpdateAutor(autor);
        }

        public bool UpdateTema(Tema topic, string newCode = "", string newDesc = "")
        {
            if (newCode=="")
                newCode = topic.Codigo;

            if (newDesc == "")
                newDesc = topic.Descripcion;

            return obj.UpdateTema(topic, newCode, newDesc);
        }

        public bool AddEditorial(FullEditorial publisher)
        {
            return obj.AddEditorial(publisher);
        }

        public DataTable MostrarEditoriales()
        {
            return obj.MostrarEditoriales();
        }

        public bool UpdateEditorial(FullEditorial oldEditorial, FullEditorial newEditorial)
        {
            return obj.UpdateEditorial(oldEditorial, newEditorial);
        }

        public bool DeletePublisher(FullEditorial editorial)
        {
            return obj.DeletePublisher(editorial);
        }

        public bool AddAuthor(FullAutor autor)
        {
            return obj.AddAuthor(autor);
        }

        public bool DeleteAutor(string codigo)
        {
            return obj.DeleteAutor(codigo);
        }

        public List<Tema> ListarTemas(int start, int end)
        {
            return obj.ListarTemas(start, end);
        }

        public List<EditorialSencillo> LoadEditoriales()
        {
            return obj.LoadEditoriales();
        }

        public List<Tema> LoadTemas()
        {
            return obj.LoadTemas();
        }

        public List<AutorSimple> LoadAutores()
        {
            return obj.LoadAutores();
        }

        public FullUser GetLoggData(UserAcces param)
        {
            return obj.GetLoggData(param);
        }

        public Libro GetBookView(string codigo)
        {
            return obj.GetBookView(codigo);
        }
    }
}
