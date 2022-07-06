using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddTrsBankBillDetCommandValidator : AbstractValidator<AddTrsBankBillDetCommand>
    {
        public AddTrsBankBillDetCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
