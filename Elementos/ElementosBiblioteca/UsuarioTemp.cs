using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elementos
{
    public class UsuarioTemp
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public string Contraseña { get; set; }
        public string ConfirmarContra { get; set; }

        public UsuarioTemp()
        {

        }

        public UsuarioTemp(UsuarioTemp userTemp)
        {
            this.Nombre = userTemp.Nombre;
            this.Apellidos = userTemp.Apellidos;
            this.Correo = userTemp.Correo;
            this.Contraseña = userTemp.Contraseña;
            this.ConfirmarContra = userTemp.ConfirmarContra;
        }

        ~UsuarioTemp()
        {
        }

    }
}
