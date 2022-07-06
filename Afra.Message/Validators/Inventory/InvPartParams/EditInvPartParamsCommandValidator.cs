using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditInvPartParamsCommandValidator : AbstractValidator<EditInvPartParamsCommand>
    {
        public EditInvPartParamsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
