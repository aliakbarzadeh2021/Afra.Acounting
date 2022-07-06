using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditCstMatQtyCommandValidator : AbstractValidator<EditCstMatQtyCommand>
    {
        public EditCstMatQtyCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
