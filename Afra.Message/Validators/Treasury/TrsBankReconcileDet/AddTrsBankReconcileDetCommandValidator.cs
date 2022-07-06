using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddTrsBankReconcileDetCommandValidator : AbstractValidator<AddTrsBankReconcileDetCommand>
    {
        public AddTrsBankReconcileDetCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
