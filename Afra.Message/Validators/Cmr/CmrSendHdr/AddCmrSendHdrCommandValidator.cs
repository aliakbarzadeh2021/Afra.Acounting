using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddCmrSendHdrCommandValidator : AbstractValidator<AddCmrSendHdrCommand>
    {
        public AddCmrSendHdrCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
