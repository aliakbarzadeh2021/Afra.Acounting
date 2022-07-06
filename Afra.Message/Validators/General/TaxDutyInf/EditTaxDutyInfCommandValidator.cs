using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditTaxDutyInfCommandValidator : AbstractValidator<EditTaxDutyInfCommand>
    {
        public EditTaxDutyInfCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
