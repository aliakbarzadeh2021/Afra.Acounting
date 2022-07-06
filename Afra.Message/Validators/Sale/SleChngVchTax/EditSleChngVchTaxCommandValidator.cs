using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditSleChngVchTaxCommandValidator : AbstractValidator<EditSleChngVchTaxCommand>
    {
        public EditSleChngVchTaxCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
