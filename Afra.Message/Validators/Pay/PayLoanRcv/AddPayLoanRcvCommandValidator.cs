using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddPayLoanRcvCommandValidator : AbstractValidator<AddPayLoanRcvCommand>
    {
        public AddPayLoanRcvCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
