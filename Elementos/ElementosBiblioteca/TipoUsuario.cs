using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elementos
{
    public class TipoUsuario
    {
        private NivelAutorizacion autorizacion;
        public NivelAutorizacion Autorizacion => autorizacion;

        public TipoUsuario(NivelAutorizacion auth)
        {
            this.autorizacion = auth;
        }


        public enum NivelAutorizacion
        {
            Master,
            Admin,
            User,
            Invitado
        }

        
        public static TipoUsuario.NivelAutorizacion ConvertirNivelAutorizacion(string autorizacion)
        { 
            switch (autorizacion.ToLower())
            {
                case "master":
                    return TipoUsuario.NivelAutorizacion.Master;
                    break;

                case "admin":
                    return TipoUsuario.NivelAutorizacion.Admin;
                    break;

                case "user":
                    return TipoUsuario.NivelAutorizacion.User;
                    break;

                default:
                    return TipoUsuario.NivelAutorizacion.Invitado;
                    break;
            }
        }

    }
}
