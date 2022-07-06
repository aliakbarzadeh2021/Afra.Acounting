using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditBdgCurExchangeCommandValidator : AbstractValidator<EditBdgCurExchangeCommand>
    {
        public EditBdgCurExchangeCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
