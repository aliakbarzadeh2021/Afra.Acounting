using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddOtoUserRightCommandValidator : AbstractValidator<AddOtoUserRightCommand>
    {
        public AddOtoUserRightCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
