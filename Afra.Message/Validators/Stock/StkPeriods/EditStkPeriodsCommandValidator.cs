using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditStkPeriodsCommandValidator : AbstractValidator<EditStkPeriodsCommand>
    {
        public EditStkPeriodsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
