using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditPayLoanHistoryCommandValidator : AbstractValidator<EditPayLoanHistoryCommand>
    {
        public EditPayLoanHistoryCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
