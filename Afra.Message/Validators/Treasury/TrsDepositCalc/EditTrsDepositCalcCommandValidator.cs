using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditTrsDepositCalcCommandValidator : AbstractValidator<EditTrsDepositCalcCommand>
    {
        public EditTrsDepositCalcCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
