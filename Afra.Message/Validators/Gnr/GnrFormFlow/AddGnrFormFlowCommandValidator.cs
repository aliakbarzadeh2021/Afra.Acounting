using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddGnrFormFlowCommandValidator : AbstractValidator<AddGnrFormFlowCommand>
    {
        public AddGnrFormFlowCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
