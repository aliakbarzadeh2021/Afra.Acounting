using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddTrsGuaranteeOprCommandValidator : AbstractValidator<AddTrsGuaranteeOprCommand>
    {
        public AddTrsGuaranteeOprCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
