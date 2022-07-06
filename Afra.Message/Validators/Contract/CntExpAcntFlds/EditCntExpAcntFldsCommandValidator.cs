using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditCntExpAcntFldsCommandValidator : AbstractValidator<EditCntExpAcntFldsCommand>
    {
        public EditCntExpAcntFldsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
