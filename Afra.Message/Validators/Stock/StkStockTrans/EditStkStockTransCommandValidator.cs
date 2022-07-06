using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditStkStockTransCommandValidator : AbstractValidator<EditStkStockTransCommand>
    {
        public EditStkStockTransCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
