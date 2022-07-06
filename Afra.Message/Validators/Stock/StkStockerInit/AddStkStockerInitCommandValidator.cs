using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddStkStockerInitCommandValidator : AbstractValidator<AddStkStockerInitCommand>
    {
        public AddStkStockerInitCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
