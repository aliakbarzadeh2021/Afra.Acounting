using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddPayTaxCompsCommandValidator : AbstractValidator<AddPayTaxCompsCommand>
    {
        public AddPayTaxCompsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
