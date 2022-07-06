using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddBdgTaxDetCommandValidator : AbstractValidator<AddBdgTaxDetCommand>
    {
        public AddBdgTaxDetCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
