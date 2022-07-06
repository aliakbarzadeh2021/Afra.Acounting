using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddPayGrpLoanPersCommandValidator : AbstractValidator<AddPayGrpLoanPersCommand>
    {
        public AddPayGrpLoanPersCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
