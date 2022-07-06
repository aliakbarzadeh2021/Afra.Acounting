using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddSleBrokerSalaryCommandValidator : AbstractValidator<AddSleBrokerSalaryCommand>
    {
        public AddSleBrokerSalaryCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
