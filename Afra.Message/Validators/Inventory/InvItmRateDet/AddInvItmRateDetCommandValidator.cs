using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddInvItmRateDetCommandValidator : AbstractValidator<AddInvItmRateDetCommand>
    {
        public AddInvItmRateDetCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
