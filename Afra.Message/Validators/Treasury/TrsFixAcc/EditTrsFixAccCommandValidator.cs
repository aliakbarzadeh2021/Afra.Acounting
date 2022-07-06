using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditTrsFixAccCommandValidator : AbstractValidator<EditTrsFixAccCommand>
    {
        public EditTrsFixAccCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
