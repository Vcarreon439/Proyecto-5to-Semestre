using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elementos.ElementosBiblioteca.Editorial;
using FluentValidation;

namespace MainForm.ValidateData
{
    public class ValidatePublisher : AbstractValidator<FullEditorial>
    {
        public ValidatePublisher()
        {
            RuleFor(x => x.Codigo).NotEmpty();
            RuleFor(x => x.Nombre).NotEmpty();

            RuleFor(x => x.Correo).EmailAddress();
        }
    }
}
