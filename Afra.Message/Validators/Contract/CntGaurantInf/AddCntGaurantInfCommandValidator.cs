using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddCntGaurantInfCommandValidator : AbstractValidator<AddCntGaurantInfCommand>
    {
        public AddCntGaurantInfCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
