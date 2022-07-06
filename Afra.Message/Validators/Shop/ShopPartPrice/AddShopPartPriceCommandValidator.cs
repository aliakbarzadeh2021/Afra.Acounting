using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddShopPartPriceCommandValidator : AbstractValidator<AddShopPartPriceCommand>
    {
        public AddShopPartPriceCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
