using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditWorkFlowsCommandValidator : AbstractValidator<EditWorkFlowsCommand>
    {
        public EditWorkFlowsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
