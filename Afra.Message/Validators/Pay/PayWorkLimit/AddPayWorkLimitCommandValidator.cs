using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddPayWorkLimitCommandValidator : AbstractValidator<AddPayWorkLimitCommand>
    {
        public AddPayWorkLimitCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
