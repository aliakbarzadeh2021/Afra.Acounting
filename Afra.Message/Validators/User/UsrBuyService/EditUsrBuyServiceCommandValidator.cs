using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditUsrBuyServiceCommandValidator : AbstractValidator<EditUsrBuyServiceCommand>
    {
        public EditUsrBuyServiceCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
