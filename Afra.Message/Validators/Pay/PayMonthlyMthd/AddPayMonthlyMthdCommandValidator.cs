using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddPayMonthlyMthdCommandValidator : AbstractValidator<AddPayMonthlyMthdCommand>
    {
        public AddPayMonthlyMthdCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
