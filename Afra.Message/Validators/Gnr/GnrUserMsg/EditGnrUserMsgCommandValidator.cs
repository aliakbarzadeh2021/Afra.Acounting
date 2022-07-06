using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditGnrUserMsgCommandValidator : AbstractValidator<EditGnrUserMsgCommand>
    {
        public EditGnrUserMsgCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
