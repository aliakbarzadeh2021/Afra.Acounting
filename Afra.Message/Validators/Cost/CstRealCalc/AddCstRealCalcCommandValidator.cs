using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddCstRealCalcCommandValidator : AbstractValidator<AddCstRealCalcCommand>
    {
        public AddCstRealCalcCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
