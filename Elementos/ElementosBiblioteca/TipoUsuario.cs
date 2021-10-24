using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elementos
{
    /// <summary>
    /// Clase para los permisos del usuario
    /// </summary>
    public class TipoUsuario
    {
        /// <summary>
        /// Enum publico para el Nivel de Autorizacion
        /// </summary>
        public enum NivelAutorizacion
        {
            /// <summary>
            /// Maximo nivel de permisos
            /// </summary>
            Master,

            /// <summary>
            /// Permisos administrativos
            /// </summary>
            Admin,

            /// <summary>
            /// Permisos básicos de usuario
            /// </summary>
            User,

            /// <summary>
            /// Permisos de bajo nivel, unicamente para observar la interfaz
            /// </summary>
            Invitado
        }

        /// <summary>
        /// Variable interna para el nivel de autorizacion
        /// </summary>
        private NivelAutorizacion autorizacion;

        /// <summary>
        /// Variable de solo lectura del Nivel de Autorización
        /// </summary>
        public NivelAutorizacion Autorizacion => autorizacion;

        /// <summary>
        /// Constructor que define las propiedades de la autorización.
        /// </summary>
        /// <param name="auth">NivelAutorizacion que se asigna a autorizacion</param>
        public TipoUsuario(NivelAutorizacion auth)
        {
            this.autorizacion = auth;
        }

        

        /// <summary>
        /// Convierte una cadena en TipoUsuario.NivelAutorizacion en caso de no ser el formato correcto,
        /// se regresará los permisos de bajo nivel. 
        /// </summary>
        /// <param name="autorizacion">Solo se permiten "master", "admin", "user"</param>
        /// <returns>Nivel de autorizacion</returns>
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
