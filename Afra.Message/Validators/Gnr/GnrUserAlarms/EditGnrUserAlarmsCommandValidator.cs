using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditGnrUserAlarmsCommandValidator : AbstractValidator<EditGnrUserAlarmsCommand>
    {
        public EditGnrUserAlarmsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
