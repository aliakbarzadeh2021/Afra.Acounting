using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddTrsDepositCalcCommandValidator : AbstractValidator<AddTrsDepositCalcCommand>
    {
        public AddTrsDepositCalcCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
