using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditSleTaxesCommandValidator : AbstractValidator<EditSleTaxesCommand>
    {
        public EditSleTaxesCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
