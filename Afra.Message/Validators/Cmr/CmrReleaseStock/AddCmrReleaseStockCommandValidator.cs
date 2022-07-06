using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddCmrReleaseStockCommandValidator : AbstractValidator<AddCmrReleaseStockCommand>
    {
        public AddCmrReleaseStockCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
