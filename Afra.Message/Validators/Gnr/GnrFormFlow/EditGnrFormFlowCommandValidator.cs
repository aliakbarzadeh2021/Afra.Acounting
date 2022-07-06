using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditGnrFormFlowCommandValidator : AbstractValidator<EditGnrFormFlowCommand>
    {
        public EditGnrFormFlowCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
