using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditCntExpFldElmntsCommandValidator : AbstractValidator<EditCntExpFldElmntsCommand>
    {
        public EditCntExpFldElmntsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
