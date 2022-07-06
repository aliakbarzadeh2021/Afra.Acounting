using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditTrsSourceUseRelsCommandValidator : AbstractValidator<EditTrsSourceUseRelsCommand>
    {
        public EditTrsSourceUseRelsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
