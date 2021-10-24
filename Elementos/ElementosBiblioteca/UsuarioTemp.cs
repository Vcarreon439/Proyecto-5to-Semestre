using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elementos
{
    /// <summary>
    /// Clase UsuarioTemp, utilizada para el registro rapido de un usuario
    /// </summary>
    public class UsuarioTemp
    {
        /// <summary>
        /// Nombre del usuario
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Apellidos del usuario
        /// </summary>
        public string Apellidos { get; set; }

        /// <summary>
        /// Correo del usuario
        /// </summary>
        public string Correo { get; set; }

        /// <summary>
        /// Contraseña del usuario
        /// </summary>
        public string Contraseña { get; set; }

        /// <summary>
        /// Confirmacion de contraseña del usuario
        /// </summary>
        public string ConfirmarContra { get; set; }

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public UsuarioTemp() { }

        /// <summary>
        /// Define las propiedades de la clase en base a un UsuarioTemp
        /// </summary>
        /// <param name="userTemp">UsuarioTemp del cual se toman los datos</param>
        public UsuarioTemp(UsuarioTemp userTemp)
        {
            this.Nombre = userTemp.Nombre;
            this.Apellidos = userTemp.Apellidos;
            this.Correo = userTemp.Correo;
            this.Contraseña = userTemp.Contraseña;
            this.ConfirmarContra = userTemp.ConfirmarContra;
        }

        ~UsuarioTemp() { }
    }
}
