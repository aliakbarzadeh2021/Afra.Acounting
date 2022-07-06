using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddShopTaxValsCommandValidator : AbstractValidator<AddShopTaxValsCommand>
    {
        public AddShopTaxValsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
