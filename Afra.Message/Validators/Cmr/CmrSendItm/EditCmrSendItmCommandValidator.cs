using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditCmrSendItmCommandValidator : AbstractValidator<EditCmrSendItmCommand>
    {
        public EditCmrSendItmCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
