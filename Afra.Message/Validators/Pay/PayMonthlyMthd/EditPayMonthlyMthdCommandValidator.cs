using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditPayMonthlyMthdCommandValidator : AbstractValidator<EditPayMonthlyMthdCommand>
    {
        public EditPayMonthlyMthdCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
