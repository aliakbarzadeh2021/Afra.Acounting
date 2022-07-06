using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditInvItmRateDetCommandValidator : AbstractValidator<EditInvItmRateDetCommand>
    {
        public EditInvItmRateDetCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
