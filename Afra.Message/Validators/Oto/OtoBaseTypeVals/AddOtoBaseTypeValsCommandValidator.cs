using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddOtoBaseTypeValsCommandValidator : AbstractValidator<AddOtoBaseTypeValsCommand>
    {
        public AddOtoBaseTypeValsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
