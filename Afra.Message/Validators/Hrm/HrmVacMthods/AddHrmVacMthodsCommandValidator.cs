using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddHrmVacMthodsCommandValidator : AbstractValidator<AddHrmVacMthodsCommand>
    {
        public AddHrmVacMthodsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
