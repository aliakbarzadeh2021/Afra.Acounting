using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditSleBrokerCalcCommandValidator : AbstractValidator<EditSleBrokerCalcCommand>
    {
        public EditSleBrokerCalcCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
