using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddSleVchTaxCommandValidator : AbstractValidator<AddSleVchTaxCommand>
    {
        public AddSleVchTaxCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
