using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditHrmParamStatsCommandValidator : AbstractValidator<EditHrmParamStatsCommand>
    {
        public EditHrmParamStatsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
