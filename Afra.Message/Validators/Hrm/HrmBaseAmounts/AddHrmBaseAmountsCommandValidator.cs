using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddHrmBaseAmountsCommandValidator : AbstractValidator<AddHrmBaseAmountsCommand>
    {
        public AddHrmBaseAmountsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
