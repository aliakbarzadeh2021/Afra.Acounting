using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditPayMonthlyValsCommandValidator : AbstractValidator<EditPayMonthlyValsCommand>
    {
        public EditPayMonthlyValsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
