using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditPayTaxCompsCommandValidator : AbstractValidator<EditPayTaxCompsCommand>
    {
        public EditPayTaxCompsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
