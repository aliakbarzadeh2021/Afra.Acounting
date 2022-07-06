using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditShopGiftCardCommandValidator : AbstractValidator<EditShopGiftCardCommand>
    {
        public EditShopGiftCardCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
