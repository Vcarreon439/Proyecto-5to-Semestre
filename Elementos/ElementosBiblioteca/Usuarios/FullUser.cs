using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elementos
{
    /// <summary>
    /// Clase FullUser, utilizada para mostrar todos los datos de su cuenta al usuario
    /// </summary>
    public class FullUser : UsuarioTemp
    {
        /// <summary>
        /// Entidad Federativa del Usuario
        /// </summary>
        public string Entidad { get; set; }
        
        /// <summary>
        /// Género del usuario
        /// </summary>
        public string Genero { get; set; }
        
        /// <summary>
        /// Domicilio del usuario
        /// </summary>
        public string Domicilio { get; set; }
        
        /// <summary>
        /// Situacion del usuario
        /// </summary>
        public string Situacion { get; set; }
        
        /// <summary>
        /// Imagen de perfil del usuario en formato cadena
        /// </summary>
        public string ImagenUsuario { get; set; }
        
        /// <summary>
        /// Fecha de nacimiento del usuario
        /// </summary>
        public DateTime FechaDateTime { get; set; }

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public FullUser() { }
        ~FullUser() { }
    }
}
