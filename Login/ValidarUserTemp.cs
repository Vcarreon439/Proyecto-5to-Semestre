using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elementos;
using FluentValidation;

namespace Login
{
    public class ValidarUserTemp : AbstractValidator<UsuarioTemp>
    {
        public ValidarUserTemp()
        {
            RuleFor(x => x.Nombre).NotEmpty();
            RuleFor(x => x.Apellidos).NotEmpty();
            RuleFor(x => x.Correo).NotEmpty();
            RuleFor(x => x.Contraseña).NotEmpty();

            RuleFor(x => x.Correo).EmailAddress();
            RuleFor(x => x.ConfirmarContra).Matches(x => x.Contraseña).WithMessage("Las contraseñas deben ser las mismas");
        }

    }

    public class ValidarAcceso : AbstractValidator<UserAcces>
    {
        public ValidarAcceso()
        {
            RuleFor(x => x.Correo).NotEmpty();
            RuleFor(x => x.Contraseña).NotEmpty();
            RuleFor(x => x.Correo).EmailAddress();
        }
    }
}
