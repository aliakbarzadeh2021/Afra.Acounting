using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddOtoBaseTypesCommandValidator : AbstractValidator<AddOtoBaseTypesCommand>
    {
        public AddOtoBaseTypesCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
