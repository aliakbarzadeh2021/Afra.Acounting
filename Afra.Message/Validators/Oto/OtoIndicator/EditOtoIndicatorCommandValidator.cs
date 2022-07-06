using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditOtoIndicatorCommandValidator : AbstractValidator<EditOtoIndicatorCommand>
    {
        public EditOtoIndicatorCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
