using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddHrmCalenderDetCommandValidator : AbstractValidator<AddHrmCalenderDetCommand>
    {
        public AddHrmCalenderDetCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
