using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditSleBrokerSalaryRelsCommandValidator : AbstractValidator<EditSleBrokerSalaryRelsCommand>
    {
        public EditSleBrokerSalaryRelsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
