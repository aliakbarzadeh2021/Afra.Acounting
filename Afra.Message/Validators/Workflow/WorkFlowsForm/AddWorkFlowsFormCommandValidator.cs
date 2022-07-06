using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddWorkFlowsFormCommandValidator : AbstractValidator<AddWorkFlowsFormCommand>
    {
        public AddWorkFlowsFormCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
