using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditSlePriceHdrCommandValidator : AbstractValidator<EditSlePriceHdrCommand>
    {
        public EditSlePriceHdrCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
