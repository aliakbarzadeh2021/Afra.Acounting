using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditWorkFlowsFormCommandValidator : AbstractValidator<EditWorkFlowsFormCommand>
    {
        public EditWorkFlowsFormCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
