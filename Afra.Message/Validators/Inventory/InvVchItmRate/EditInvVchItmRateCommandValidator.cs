using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditInvVchItmRateCommandValidator : AbstractValidator<EditInvVchItmRateCommand>
    {
        public EditInvVchItmRateCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
