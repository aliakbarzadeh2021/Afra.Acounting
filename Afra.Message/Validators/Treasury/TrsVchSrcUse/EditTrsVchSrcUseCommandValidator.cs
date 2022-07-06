using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditTrsVchSrcUseCommandValidator : AbstractValidator<EditTrsVchSrcUseCommand>
    {
        public EditTrsVchSrcUseCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
