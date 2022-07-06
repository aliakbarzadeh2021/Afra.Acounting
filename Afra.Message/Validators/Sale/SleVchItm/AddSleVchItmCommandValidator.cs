using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddSleVchItmCommandValidator : AbstractValidator<AddSleVchItmCommand>
    {
        public AddSleVchItmCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
