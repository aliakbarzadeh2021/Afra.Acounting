using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditSleSrvTaxCommandValidator : AbstractValidator<EditSleSrvTaxCommand>
    {
        public EditSleSrvTaxCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
