using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditBdgPeriodsCommandValidator : AbstractValidator<EditBdgPeriodsCommand>
    {
        public EditBdgPeriodsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
