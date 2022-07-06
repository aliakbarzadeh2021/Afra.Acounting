using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditGnrLimitExceptCommandValidator : AbstractValidator<EditGnrLimitExceptCommand>
    {
        public EditGnrLimitExceptCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
