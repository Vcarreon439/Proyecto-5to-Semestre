using System;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;

namespace Elementos
{
    /// <summary>
    /// Clase auxiliar para conversión de imagenes
    /// </summary>
    public class ImageConvertions
    {
        /// <summary>
        /// Convierte una imagen a una cadena de caracteres
        /// </summary>
        /// <param name="image">Imagen a convertir</param>
        /// <param name="formato">Formato de imagen</param>
        /// <returns>Cadena de caracteres de longitud 64</returns>
        public static string ImageToBase64(Image image, ImageFormat formato)
        {
            if (image == null)
                return null;

            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, formato);
                byte[] imBytes = ms.ToArray();
                string base64string = Convert.ToBase64String(imBytes);

                return base64string;
            }
        }

        /// <summary>
        /// Convierte de una cadena a imagen
        /// </summary>
        /// <param name="base64string">Cadena a convertir</param>
        /// <returns>Imagen resultante</returns>
        public static Image Base64ToImage(string base64string)
        {
            if (base64string == "")
                return null;

            if (base64string != null)
            {
                byte[] imBytes = Convert.FromBase64String(base64string);
                MemoryStream ms = new MemoryStream(imBytes, 0, imBytes.Length);
                ms.Write(imBytes, 0, imBytes.Length);
                Image imagen = Image.FromStream(ms, true);
                return imagen;
            }
            else
                return null;
        }

    }
}
