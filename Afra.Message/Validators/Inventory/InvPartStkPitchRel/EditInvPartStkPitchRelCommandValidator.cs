using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditInvPartStkPitchRelCommandValidator : AbstractValidator<EditInvPartStkPitchRelCommand>
    {
        public EditInvPartStkPitchRelCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
