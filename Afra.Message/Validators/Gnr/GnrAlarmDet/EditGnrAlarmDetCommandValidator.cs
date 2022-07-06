using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditGnrAlarmDetCommandValidator : AbstractValidator<EditGnrAlarmDetCommand>
    {
        public EditGnrAlarmDetCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
