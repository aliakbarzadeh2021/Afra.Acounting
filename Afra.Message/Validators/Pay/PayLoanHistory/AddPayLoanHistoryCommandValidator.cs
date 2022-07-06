using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddPayLoanHistoryCommandValidator : AbstractValidator<AddPayLoanHistoryCommand>
    {
        public AddPayLoanHistoryCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
