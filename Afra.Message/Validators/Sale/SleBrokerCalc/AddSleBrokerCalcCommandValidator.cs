using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddSleBrokerCalcCommandValidator : AbstractValidator<AddSleBrokerCalcCommand>
    {
        public AddSleBrokerCalcCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
