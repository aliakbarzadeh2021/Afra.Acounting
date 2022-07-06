using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditPrdSchStopCommandValidator : AbstractValidator<EditPrdSchStopCommand>
    {
        public EditPrdSchStopCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
