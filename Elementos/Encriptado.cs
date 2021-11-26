using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Elementos
{
    /// <summary>
    /// Clase para el encriptado de elementos
    /// </summary>
    public static class Encriptado
    {
        /// <summary>
        /// Encripta una cadena con Encoder UTF8
        /// </summary>
        /// <param name="value">Cadena a encriptar</param>
        /// <returns>La cadena encriptada</returns>
        public static string Encrypt(string value)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf8.GetBytes(value));
                return Convert.ToBase64String(data);
            }
        }

    }
}
