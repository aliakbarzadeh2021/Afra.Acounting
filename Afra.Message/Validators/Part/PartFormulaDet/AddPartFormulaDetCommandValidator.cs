using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddPartFormulaDetCommandValidator : AbstractValidator<AddPartFormulaDetCommand>
    {
        public AddPartFormulaDetCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
