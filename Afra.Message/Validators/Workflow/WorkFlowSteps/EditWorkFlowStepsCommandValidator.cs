using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditWorkFlowStepsCommandValidator : AbstractValidator<EditWorkFlowStepsCommand>
    {
        public EditWorkFlowStepsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
