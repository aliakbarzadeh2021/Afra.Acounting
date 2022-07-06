using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddGnrLimitUserCommandValidator : AbstractValidator<AddGnrLimitUserCommand>
    {
        public AddGnrLimitUserCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
