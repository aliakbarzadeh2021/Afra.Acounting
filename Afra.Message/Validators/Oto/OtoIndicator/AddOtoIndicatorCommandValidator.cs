using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddOtoIndicatorCommandValidator : AbstractValidator<AddOtoIndicatorCommand>
    {
        public AddOtoIndicatorCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
