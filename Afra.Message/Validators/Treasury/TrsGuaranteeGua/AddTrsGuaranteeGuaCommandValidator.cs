using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddTrsGuaranteeGuaCommandValidator : AbstractValidator<AddTrsGuaranteeGuaCommand>
    {
        public AddTrsGuaranteeGuaCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
