using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddSleBrokerSalaryMthdCommandValidator : AbstractValidator<AddSleBrokerSalaryMthdCommand>
    {
        public AddSleBrokerSalaryMthdCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
