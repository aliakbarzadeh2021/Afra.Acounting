using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddHrmCalendarsCommandValidator : AbstractValidator<AddHrmCalendarsCommand>
    {
        public AddHrmCalendarsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
