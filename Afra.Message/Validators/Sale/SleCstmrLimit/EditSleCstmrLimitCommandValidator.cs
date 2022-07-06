using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditSleCstmrLimitCommandValidator : AbstractValidator<EditSleCstmrLimitCommand>
    {
        public EditSleCstmrLimitCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
