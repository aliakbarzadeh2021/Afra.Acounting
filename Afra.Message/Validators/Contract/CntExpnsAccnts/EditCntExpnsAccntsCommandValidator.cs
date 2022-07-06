using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditCntExpnsAccntsCommandValidator : AbstractValidator<EditCntExpnsAccntsCommand>
    {
        public EditCntExpnsAccntsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
