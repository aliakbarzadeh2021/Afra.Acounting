using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditTrsFacManCreditCommandValidator : AbstractValidator<EditTrsFacManCreditCommand>
    {
        public EditTrsFacManCreditCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
