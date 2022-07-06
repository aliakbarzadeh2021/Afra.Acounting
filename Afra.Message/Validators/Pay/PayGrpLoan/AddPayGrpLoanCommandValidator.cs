using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddPayGrpLoanCommandValidator : AbstractValidator<AddPayGrpLoanCommand>
    {
        public AddPayGrpLoanCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
