using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditOtoFlowRightCommandValidator : AbstractValidator<EditOtoFlowRightCommand>
    {
        public EditOtoFlowRightCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
