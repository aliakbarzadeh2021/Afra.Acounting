using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddOtoFlowCrsCommandValidator : AbstractValidator<AddOtoFlowCrsCommand>
    {
        public AddOtoFlowCrsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
