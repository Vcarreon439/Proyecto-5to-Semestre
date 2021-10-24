using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elementos
{
    public class UserAcces
    {
        public string Correo { get; set; }
        public string Contraseña { get; set; }

        public UserAcces(UserAcces user)
        {
            this.Contraseña = user.Contraseña;
            this.Correo = user.Correo;
        }

        public UserAcces()
        {

        }

        ~UserAcces()
        {

        }

    }
}
