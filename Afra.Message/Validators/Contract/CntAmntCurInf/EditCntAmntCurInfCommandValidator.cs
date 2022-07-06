using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditCntAmntCurInfCommandValidator : AbstractValidator<EditCntAmntCurInfCommand>
    {
        public EditCntAmntCurInfCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
