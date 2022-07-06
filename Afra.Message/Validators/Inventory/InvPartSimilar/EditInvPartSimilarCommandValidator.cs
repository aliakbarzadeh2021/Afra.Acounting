using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditInvPartSimilarCommandValidator : AbstractValidator<EditInvPartSimilarCommand>
    {
        public EditInvPartSimilarCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
