using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditCstMatStdInfCommandValidator : AbstractValidator<EditCstMatStdInfCommand>
    {
        public EditCstMatStdInfCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
