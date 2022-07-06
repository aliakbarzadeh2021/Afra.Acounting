using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditTrsFundBillHdrCommandValidator : AbstractValidator<EditTrsFundBillHdrCommand>
    {
        public EditTrsFundBillHdrCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
