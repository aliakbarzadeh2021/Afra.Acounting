using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditOtoFlowCrsCommandValidator : AbstractValidator<EditOtoFlowCrsCommand>
    {
        public EditOtoFlowCrsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
