using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditHrmPrsntStatCommandValidator : AbstractValidator<EditHrmPrsntStatCommand>
    {
        public EditHrmPrsntStatCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
