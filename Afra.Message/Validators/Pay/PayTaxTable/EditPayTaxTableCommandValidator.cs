using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditPayTaxTableCommandValidator : AbstractValidator<EditPayTaxTableCommand>
    {
        public EditPayTaxTableCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
