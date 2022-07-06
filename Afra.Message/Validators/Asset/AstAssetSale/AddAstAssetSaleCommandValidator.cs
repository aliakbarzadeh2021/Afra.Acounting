using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddAstAssetSaleCommandValidator : AbstractValidator<AddAstAssetSaleCommand>
    {
        public AddAstAssetSaleCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
