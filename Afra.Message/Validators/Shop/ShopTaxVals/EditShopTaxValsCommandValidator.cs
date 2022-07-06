using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditShopTaxValsCommandValidator : AbstractValidator<EditShopTaxValsCommand>
    {
        public EditShopTaxValsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
