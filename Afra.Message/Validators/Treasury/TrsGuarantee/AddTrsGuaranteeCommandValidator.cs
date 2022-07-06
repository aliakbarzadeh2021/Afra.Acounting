using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddTrsGuaranteeCommandValidator : AbstractValidator<AddTrsGuaranteeCommand>
    {
        public AddTrsGuaranteeCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
