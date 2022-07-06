using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditSleBrokerSalaryCommandValidator : AbstractValidator<EditSleBrokerSalaryCommand>
    {
        public EditSleBrokerSalaryCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
