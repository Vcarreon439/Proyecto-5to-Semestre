using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;
using Elementos;
using Elementos.ElementosBiblioteca.Autor;
using FluentValidation;

namespace MainForm.ValidateData
{
    class ValidateBook : AbstractValidator<Libro>
    {
        public ValidateBook()
        {
            RuleFor(x => x.Titulo).NotEmpty();
            RuleFor(x => x.AñoEdicion).GreaterThan(0);
            RuleFor(x => x.Copias).GreaterThan(-1);
        }
    }
}
