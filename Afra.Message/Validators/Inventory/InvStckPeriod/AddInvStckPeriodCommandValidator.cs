using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddInvStckPeriodCommandValidator : AbstractValidator<AddInvStckPeriodCommand>
    {
        public AddInvStckPeriodCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
