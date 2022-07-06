using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditPayVacRemainCommandValidator : AbstractValidator<EditPayVacRemainCommand>
    {
        public EditPayVacRemainCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
