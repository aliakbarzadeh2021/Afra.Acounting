using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditTrsFacTypeInfCommandValidator : AbstractValidator<EditTrsFacTypeInfCommand>
    {
        public EditTrsFacTypeInfCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
