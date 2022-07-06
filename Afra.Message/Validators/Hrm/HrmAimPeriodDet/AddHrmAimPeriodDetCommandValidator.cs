using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddHrmAimPeriodDetCommandValidator : AbstractValidator<AddHrmAimPeriodDetCommand>
    {
        public AddHrmAimPeriodDetCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
