using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditCntContrLimitCommandValidator : AbstractValidator<EditCntContrLimitCommand>
    {
        public EditCntContrLimitCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
