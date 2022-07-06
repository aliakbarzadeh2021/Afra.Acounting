using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditBdgFinalRepCommandValidator : AbstractValidator<EditBdgFinalRepCommand>
    {
        public EditBdgFinalRepCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
