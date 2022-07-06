using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddUserAlternativeCommandValidator : AbstractValidator<AddUserAlternativeCommand>
    {
        public AddUserAlternativeCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
