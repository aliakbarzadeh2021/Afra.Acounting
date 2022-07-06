using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddSleGuaranteeCommandValidator : AbstractValidator<AddSleGuaranteeCommand>
    {
        public AddSleGuaranteeCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
