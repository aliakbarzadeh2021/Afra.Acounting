using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditStkStockerInitCommandValidator : AbstractValidator<EditStkStockerInitCommand>
    {
        public EditStkStockerInitCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
