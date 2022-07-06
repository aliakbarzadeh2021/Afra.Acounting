using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddBdgPeriodsCommandValidator : AbstractValidator<AddBdgPeriodsCommand>
    {
        public AddBdgPeriodsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
