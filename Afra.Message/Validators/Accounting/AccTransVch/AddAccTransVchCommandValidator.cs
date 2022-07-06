using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddAccTransVchCommandValidator : AbstractValidator<AddAccTransVchCommand>
    {
        public AddAccTransVchCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
