using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditInvPartDLInfCommandValidator : AbstractValidator<EditInvPartDLInfCommand>
    {
        public EditInvPartDLInfCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
