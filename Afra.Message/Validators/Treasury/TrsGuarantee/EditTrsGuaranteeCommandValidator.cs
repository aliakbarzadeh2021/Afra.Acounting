using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditTrsGuaranteeCommandValidator : AbstractValidator<EditTrsGuaranteeCommand>
    {
        public EditTrsGuaranteeCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
