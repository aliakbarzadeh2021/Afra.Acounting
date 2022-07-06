using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditPayGrpLoanPersCommandValidator : AbstractValidator<EditPayGrpLoanPersCommand>
    {
        public EditPayGrpLoanPersCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
