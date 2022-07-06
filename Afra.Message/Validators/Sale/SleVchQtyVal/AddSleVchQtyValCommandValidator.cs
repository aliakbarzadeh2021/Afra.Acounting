using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddSleVchQtyValCommandValidator : AbstractValidator<AddSleVchQtyValCommand>
    {
        public AddSleVchQtyValCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
