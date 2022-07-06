using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditSleBrokerSalaryTaxCommandValidator : AbstractValidator<EditSleBrokerSalaryTaxCommand>
    {
        public EditSleBrokerSalaryTaxCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
