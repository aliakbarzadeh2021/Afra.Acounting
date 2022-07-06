using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditHrmCalenderDetCommandValidator : AbstractValidator<EditHrmCalenderDetCommand>
    {
        public EditHrmCalenderDetCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
