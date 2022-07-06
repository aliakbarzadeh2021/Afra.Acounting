using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditInvVchQtyValCommandValidator : AbstractValidator<EditInvVchQtyValCommand>
    {
        public EditInvVchQtyValCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
