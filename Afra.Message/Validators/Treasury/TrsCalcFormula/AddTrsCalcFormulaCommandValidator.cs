using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddTrsCalcFormulaCommandValidator : AbstractValidator<AddTrsCalcFormulaCommand>
    {
        public AddTrsCalcFormulaCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
