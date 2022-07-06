using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditInvStkPitchsCommandValidator : AbstractValidator<EditInvStkPitchsCommand>
    {
        public EditInvStkPitchsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
