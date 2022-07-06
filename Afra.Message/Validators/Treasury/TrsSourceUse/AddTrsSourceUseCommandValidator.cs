using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddTrsSourceUseCommandValidator : AbstractValidator<AddTrsSourceUseCommand>
    {
        public AddTrsSourceUseCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
