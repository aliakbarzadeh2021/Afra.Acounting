using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddWorkFlowStepsCommandValidator : AbstractValidator<AddWorkFlowStepsCommand>
    {
        public AddWorkFlowStepsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
