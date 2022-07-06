using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditTrsFundBillItmCommandValidator : AbstractValidator<EditTrsFundBillItmCommand>
    {
        public EditTrsFundBillItmCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
