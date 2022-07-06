using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddBdgCurExchangeCommandValidator : AbstractValidator<AddBdgCurExchangeCommand>
    {
        public AddBdgCurExchangeCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
