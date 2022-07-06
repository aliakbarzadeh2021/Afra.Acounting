using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditAccSLStdDescCommandValidator : AbstractValidator<EditAccSLStdDescCommand>
    {
        public EditAccSLStdDescCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
