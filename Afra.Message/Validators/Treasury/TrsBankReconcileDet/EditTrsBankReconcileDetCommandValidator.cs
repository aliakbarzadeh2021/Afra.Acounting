using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditTrsBankReconcileDetCommandValidator : AbstractValidator<EditTrsBankReconcileDetCommand>
    {
        public EditTrsBankReconcileDetCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
