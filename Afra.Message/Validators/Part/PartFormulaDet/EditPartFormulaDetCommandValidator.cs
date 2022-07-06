using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditPartFormulaDetCommandValidator : AbstractValidator<EditPartFormulaDetCommand>
    {
        public EditPartFormulaDetCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
