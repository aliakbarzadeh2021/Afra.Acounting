using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddGnrAlarmDetCommandValidator : AbstractValidator<AddGnrAlarmDetCommand>
    {
        public AddGnrAlarmDetCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
