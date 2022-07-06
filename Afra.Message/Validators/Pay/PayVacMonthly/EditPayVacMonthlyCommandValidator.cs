using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditPayVacMonthlyCommandValidator : AbstractValidator<EditPayVacMonthlyCommand>
    {
        public EditPayVacMonthlyCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
