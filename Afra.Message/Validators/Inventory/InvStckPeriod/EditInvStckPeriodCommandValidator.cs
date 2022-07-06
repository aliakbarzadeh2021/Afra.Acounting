using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditInvStckPeriodCommandValidator : AbstractValidator<EditInvStckPeriodCommand>
    {
        public EditInvStckPeriodCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
