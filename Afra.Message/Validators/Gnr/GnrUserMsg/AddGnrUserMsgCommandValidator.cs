using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddGnrUserMsgCommandValidator : AbstractValidator<AddGnrUserMsgCommand>
    {
        public AddGnrUserMsgCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
