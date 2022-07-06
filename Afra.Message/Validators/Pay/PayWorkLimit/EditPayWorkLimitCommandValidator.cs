using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditPayWorkLimitCommandValidator : AbstractValidator<EditPayWorkLimitCommand>
    {
        public EditPayWorkLimitCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
