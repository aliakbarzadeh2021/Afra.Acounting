using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditHrmVacMthodsCommandValidator : AbstractValidator<EditHrmVacMthodsCommand>
    {
        public EditHrmVacMthodsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
