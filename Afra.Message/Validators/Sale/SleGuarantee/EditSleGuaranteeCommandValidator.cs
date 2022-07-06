using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditSleGuaranteeCommandValidator : AbstractValidator<EditSleGuaranteeCommand>
    {
        public EditSleGuaranteeCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
