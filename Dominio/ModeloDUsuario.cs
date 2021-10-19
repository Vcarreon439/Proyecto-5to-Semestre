using System;
using System.Collections.Generic;
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

        public bool RegisterNew(UsuarioTemp temp)
        {
            return obj.RegisterNew(temp);
        }

        public FullUser Login(UsuarioTemp temp)
        {
            return obj.LoginUser(temp);
        }
    }
}
