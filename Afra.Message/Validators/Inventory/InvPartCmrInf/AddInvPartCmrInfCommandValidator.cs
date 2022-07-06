using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddInvPartCmrInfCommandValidator : AbstractValidator<AddInvPartCmrInfCommand>
    {
        public AddInvPartCmrInfCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
