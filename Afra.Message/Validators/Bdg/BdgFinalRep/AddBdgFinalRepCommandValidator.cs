using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddBdgFinalRepCommandValidator : AbstractValidator<AddBdgFinalRepCommand>
    {
        public AddBdgFinalRepCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
