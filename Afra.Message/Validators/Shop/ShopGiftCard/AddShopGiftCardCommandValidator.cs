using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddShopGiftCardCommandValidator : AbstractValidator<AddShopGiftCardCommand>
    {
        public AddShopGiftCardCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
