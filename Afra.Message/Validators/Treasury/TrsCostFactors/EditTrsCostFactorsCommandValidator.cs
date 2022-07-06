using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditTrsCostFactorsCommandValidator : AbstractValidator<EditTrsCostFactorsCommand>
    {
        public EditTrsCostFactorsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
