using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditHrmBaseAmountsCommandValidator : AbstractValidator<EditHrmBaseAmountsCommand>
    {
        public EditHrmBaseAmountsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
