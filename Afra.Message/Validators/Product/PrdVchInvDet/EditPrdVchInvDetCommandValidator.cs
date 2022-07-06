using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditPrdVchInvDetCommandValidator : AbstractValidator<EditPrdVchInvDetCommand>
    {
        public EditPrdVchInvDetCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
