using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditHrmAimPeriodCommandValidator : AbstractValidator<EditHrmAimPeriodCommand>
    {
        public EditHrmAimPeriodCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
