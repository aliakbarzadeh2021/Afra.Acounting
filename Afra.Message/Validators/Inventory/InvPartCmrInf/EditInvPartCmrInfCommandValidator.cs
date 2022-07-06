using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditInvPartCmrInfCommandValidator : AbstractValidator<EditInvPartCmrInfCommand>
    {
        public EditInvPartCmrInfCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
