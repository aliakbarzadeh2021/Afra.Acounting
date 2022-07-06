using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditSleDebCreHdrCommandValidator : AbstractValidator<EditSleDebCreHdrCommand>
    {
        public EditSleDebCreHdrCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
