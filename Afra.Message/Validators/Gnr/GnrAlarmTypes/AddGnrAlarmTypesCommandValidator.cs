using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddGnrAlarmTypesCommandValidator : AbstractValidator<AddGnrAlarmTypesCommand>
    {
        public AddGnrAlarmTypesCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
