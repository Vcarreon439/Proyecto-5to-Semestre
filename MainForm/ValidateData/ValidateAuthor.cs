using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elementos.ElementosBiblioteca.Autor;
using Elementos.ElementosBiblioteca.Editorial;
using FluentValidation;

namespace MainForm.ValidateData
{
    class ValidateAuthor : AbstractValidator<FullAutor>
    {
        public ValidateAuthor()
        {
            RuleFor(x => x.Nombre).NotEmpty();
        }
    }
}
