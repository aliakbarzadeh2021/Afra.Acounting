using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddPayCalcBaseCommandValidator : AbstractValidator<AddPayCalcBaseCommand>
    {
        public AddPayCalcBaseCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
