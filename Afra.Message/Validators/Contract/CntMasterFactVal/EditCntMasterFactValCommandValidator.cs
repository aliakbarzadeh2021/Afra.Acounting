using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditCntMasterFactValCommandValidator : AbstractValidator<EditCntMasterFactValCommand>
    {
        public EditCntMasterFactValCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
