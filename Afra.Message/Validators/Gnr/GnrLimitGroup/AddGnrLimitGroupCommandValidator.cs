using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddGnrLimitGroupCommandValidator : AbstractValidator<AddGnrLimitGroupCommand>
    {
        public AddGnrLimitGroupCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
