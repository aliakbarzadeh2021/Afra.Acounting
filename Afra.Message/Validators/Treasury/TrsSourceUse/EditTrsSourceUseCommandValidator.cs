using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditTrsSourceUseCommandValidator : AbstractValidator<EditTrsSourceUseCommand>
    {
        public EditTrsSourceUseCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
