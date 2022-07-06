using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddSleBrokerSalaryTaxCommandValidator : AbstractValidator<AddSleBrokerSalaryTaxCommand>
    {
        public AddSleBrokerSalaryTaxCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
