using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elementos
{
    /// <summary>
    /// Clase UserAcces, utlizada para validar parcialmente el acceso del usuario
    /// </summary>
    public class UserAcces
    {
        /// <summary>
        /// Correo del usuario
        /// </summary>
        public string Correo { get; set; }

        /// <summary>
        /// Contraseña del usuario
        /// </summary>
        public string Contraseña { get; set; }

        /// <summary>
        /// Define las propiedades de la clase en base a un UserAcces
        /// </summary>
        /// <param name="user">UserAcces del cual se toman los datos</param>
        public UserAcces(UserAcces user)
        {
            this.Contraseña = user.Contraseña;
            this.Correo = user.Correo;
        }

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public UserAcces()
        {

        }

        ~UserAcces()
        {

        }

    }
}
