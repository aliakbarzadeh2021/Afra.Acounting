using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddTrsBankChqsCommandValidator : AbstractValidator<AddTrsBankChqsCommand>
    {
        public AddTrsBankChqsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
