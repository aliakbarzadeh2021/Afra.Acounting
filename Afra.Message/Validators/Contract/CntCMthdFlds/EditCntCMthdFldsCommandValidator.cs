using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditCntCMthdFldsCommandValidator : AbstractValidator<EditCntCMthdFldsCommand>
    {
        public EditCntCMthdFldsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
