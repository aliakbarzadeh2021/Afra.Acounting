using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddInvVchItmRateCommandValidator : AbstractValidator<AddInvVchItmRateCommand>
    {
        public AddInvVchItmRateCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
