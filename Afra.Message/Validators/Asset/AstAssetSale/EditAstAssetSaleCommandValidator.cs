using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditAstAssetSaleCommandValidator : AbstractValidator<EditAstAssetSaleCommand>
    {
        public EditAstAssetSaleCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
