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

        public TipoUsuario.NivelAutorizacion LoginUser(UserAcces temp)
        {
            return obj.LoginUser(temp);
        }

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

        public DataTable ShowAllTopics()
        {
            return obj.ShowAllTopics();
        }

        public bool UpdateTema(Tema topic, string newCode = "", string newDesc = "")
        {
            if (newCode=="")
                newCode = topic.Codigo;

            if (newDesc == "")
                newDesc = topic.Descripcion;

            return obj.UpdateTema(topic, newCode, newDesc);
        }
    }
}
