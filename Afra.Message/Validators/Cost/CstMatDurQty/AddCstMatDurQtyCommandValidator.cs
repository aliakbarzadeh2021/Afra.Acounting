using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddCstMatDurQtyCommandValidator : AbstractValidator<AddCstMatDurQtyCommand>
    {
        public AddCstMatDurQtyCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
