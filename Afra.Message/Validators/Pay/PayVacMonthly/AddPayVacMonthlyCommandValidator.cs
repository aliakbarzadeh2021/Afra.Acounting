using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddPayVacMonthlyCommandValidator : AbstractValidator<AddPayVacMonthlyCommand>
    {
        public AddPayVacMonthlyCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
