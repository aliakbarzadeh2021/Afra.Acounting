using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddTrsGuaranteeSecCommandValidator : AbstractValidator<AddTrsGuaranteeSecCommand>
    {
        public AddTrsGuaranteeSecCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
