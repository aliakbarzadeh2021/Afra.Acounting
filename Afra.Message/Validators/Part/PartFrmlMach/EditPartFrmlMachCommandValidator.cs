using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditPartFrmlMachCommandValidator : AbstractValidator<EditPartFrmlMachCommand>
    {
        public EditPartFrmlMachCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
