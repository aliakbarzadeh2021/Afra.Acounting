using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddTrsFacManCreditCommandValidator : AbstractValidator<AddTrsFacManCreditCommand>
    {
        public AddTrsFacManCreditCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
