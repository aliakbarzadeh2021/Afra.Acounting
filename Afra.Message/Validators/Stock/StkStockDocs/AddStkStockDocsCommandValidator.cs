using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddStkStockDocsCommandValidator : AbstractValidator<AddStkStockDocsCommand>
    {
        public AddStkStockDocsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
