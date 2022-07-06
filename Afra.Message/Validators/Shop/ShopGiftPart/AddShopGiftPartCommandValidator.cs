using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddShopGiftPartCommandValidator : AbstractValidator<AddShopGiftPartCommand>
    {
        public AddShopGiftPartCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
