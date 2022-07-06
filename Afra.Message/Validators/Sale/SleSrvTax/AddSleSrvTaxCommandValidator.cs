using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddSleSrvTaxCommandValidator : AbstractValidator<AddSleSrvTaxCommand>
    {
        public AddSleSrvTaxCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
