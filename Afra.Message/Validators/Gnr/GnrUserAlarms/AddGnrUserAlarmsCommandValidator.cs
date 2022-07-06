using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddGnrUserAlarmsCommandValidator : AbstractValidator<AddGnrUserAlarmsCommand>
    {
        public AddGnrUserAlarmsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
