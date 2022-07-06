using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditCntGaurantInfCommandValidator : AbstractValidator<EditCntGaurantInfCommand>
    {
        public EditCntGaurantInfCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
