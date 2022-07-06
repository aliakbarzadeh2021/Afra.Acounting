using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditTrsBankBillDetCommandValidator : AbstractValidator<EditTrsBankBillDetCommand>
    {
        public EditTrsBankBillDetCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
