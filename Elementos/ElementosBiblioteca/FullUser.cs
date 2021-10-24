using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elementos
{
    public class FullUser : UsuarioTemp
    {
        public string Entidad { get; set; }
        public string Genero { get; set; }
        public string Domicilio { get; set; }
        public string Situacion { get; set; }
        public string ImagenUsuario { get; set; }
        public DateTime FechaDateTime { get; set; }

        public FullUser() { }
        ~FullUser() { }
    }
}
