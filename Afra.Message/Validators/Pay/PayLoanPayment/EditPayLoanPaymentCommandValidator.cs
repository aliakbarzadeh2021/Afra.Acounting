using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditPayLoanPaymentCommandValidator : AbstractValidator<EditPayLoanPaymentCommand>
    {
        public EditPayLoanPaymentCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
