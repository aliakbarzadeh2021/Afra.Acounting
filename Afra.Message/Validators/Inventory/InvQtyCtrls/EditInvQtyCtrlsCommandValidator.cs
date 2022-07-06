using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditInvQtyCtrlsCommandValidator : AbstractValidator<EditInvQtyCtrlsCommand>
    {
        public EditInvQtyCtrlsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
