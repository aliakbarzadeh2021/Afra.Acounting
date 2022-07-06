using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditSleDebCreItmCommandValidator : AbstractValidator<EditSleDebCreItmCommand>
    {
        public EditSleDebCreItmCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
