using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditCstMatDurQtyCommandValidator : AbstractValidator<EditCstMatDurQtyCommand>
    {
        public EditCstMatDurQtyCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
