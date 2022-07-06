using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditCntExpAcntDetCommandValidator : AbstractValidator<EditCntExpAcntDetCommand>
    {
        public EditCntExpAcntDetCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
