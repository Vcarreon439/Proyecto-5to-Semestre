using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Elementos;

namespace Dominio
{
    public class ModeloDUsuario
    {
        private Querys obj = new Querys();

        public bool NewUser(UsuarioTemp temp)
        {
            return obj.NewUser(temp);
        }

        public FullUser Login(UsuarioTemp temp)
        {
            return obj.LoginUser(temp);
        }

        public List<LibroSencillo> MostrarPopulares()
        {
            return obj.MostrarPopulares();
        }
        public List<EditorialSencillo> Editoriales100()
        {
            return obj.Editoriales();
        }

        public bool AddBook(Book temp)
        {
            return obj.AddBook(temp);
        }

        public bool AddTema(Tema temp)
        {
            return obj.AddTema(temp);
        }

        public DataTable MostrarGeneros50()
        {
            return obj.MostrarGeneros50();
        }

    }
}
