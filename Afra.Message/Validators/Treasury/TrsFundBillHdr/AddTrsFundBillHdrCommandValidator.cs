using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddTrsFundBillHdrCommandValidator : AbstractValidator<AddTrsFundBillHdrCommand>
    {
        public AddTrsFundBillHdrCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
