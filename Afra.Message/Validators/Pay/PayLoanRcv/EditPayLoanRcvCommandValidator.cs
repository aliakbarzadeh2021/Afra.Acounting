using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditPayLoanRcvCommandValidator : AbstractValidator<EditPayLoanRcvCommand>
    {
        public EditPayLoanRcvCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
