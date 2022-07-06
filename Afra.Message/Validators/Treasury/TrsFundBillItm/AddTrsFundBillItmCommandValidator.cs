using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddTrsFundBillItmCommandValidator : AbstractValidator<AddTrsFundBillItmCommand>
    {
        public AddTrsFundBillItmCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
