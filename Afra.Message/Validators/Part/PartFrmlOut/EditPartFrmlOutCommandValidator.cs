using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditPartFrmlOutCommandValidator : AbstractValidator<EditPartFrmlOutCommand>
    {
        public EditPartFrmlOutCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
