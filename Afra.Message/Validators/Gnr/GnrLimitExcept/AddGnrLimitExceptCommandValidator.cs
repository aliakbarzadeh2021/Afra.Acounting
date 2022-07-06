using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddGnrLimitExceptCommandValidator : AbstractValidator<AddGnrLimitExceptCommand>
    {
        public AddGnrLimitExceptCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
