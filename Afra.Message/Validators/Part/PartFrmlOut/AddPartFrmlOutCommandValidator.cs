using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddPartFrmlOutCommandValidator : AbstractValidator<AddPartFrmlOutCommand>
    {
        public AddPartFrmlOutCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
