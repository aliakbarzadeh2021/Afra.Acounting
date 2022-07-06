using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddTrsBankChqsDetCommandValidator : AbstractValidator<AddTrsBankChqsDetCommand>
    {
        public AddTrsBankChqsDetCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
