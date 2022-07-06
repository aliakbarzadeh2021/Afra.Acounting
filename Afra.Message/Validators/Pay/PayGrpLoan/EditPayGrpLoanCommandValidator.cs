using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditPayGrpLoanCommandValidator : AbstractValidator<EditPayGrpLoanCommand>
    {
        public EditPayGrpLoanCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
