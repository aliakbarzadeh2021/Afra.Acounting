using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddHrmAimPeriodCommandValidator : AbstractValidator<AddHrmAimPeriodCommand>
    {
        public AddHrmAimPeriodCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
