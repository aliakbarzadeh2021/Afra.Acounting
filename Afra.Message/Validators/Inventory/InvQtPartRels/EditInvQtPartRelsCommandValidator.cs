using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditInvQtPartRelsCommandValidator : AbstractValidator<EditInvQtPartRelsCommand>
    {
        public EditInvQtPartRelsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
