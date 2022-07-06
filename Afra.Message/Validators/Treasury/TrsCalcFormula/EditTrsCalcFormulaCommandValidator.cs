using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditTrsCalcFormulaCommandValidator : AbstractValidator<EditTrsCalcFormulaCommand>
    {
        public EditTrsCalcFormulaCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
