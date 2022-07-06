using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditHrmAimPeriodDetCommandValidator : AbstractValidator<EditHrmAimPeriodDetCommand>
    {
        public EditHrmAimPeriodDetCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
