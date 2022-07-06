using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddCntExpAcntFldsCommandValidator : AbstractValidator<AddCntExpAcntFldsCommand>
    {
        public AddCntExpAcntFldsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
