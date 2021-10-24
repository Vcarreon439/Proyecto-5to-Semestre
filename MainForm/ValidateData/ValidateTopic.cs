using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elementos;
using FluentValidation;

namespace MainForm.ValidateData
{
    /// <summary>
    /// Clase para la validacion de campos de Tema
    /// </summary>
    public class ValidateTopic : AbstractValidator<Tema>
    {
        /// <summary>
        /// Establece que los campos Codigo y Descripcion no pueden estar vacios
        /// </summary>
        public ValidateTopic()
        {
            RuleFor(x => x.Codigo).NotEmpty();
            RuleFor(x => x.Descripcion).NotEmpty();
        }
    }
}
