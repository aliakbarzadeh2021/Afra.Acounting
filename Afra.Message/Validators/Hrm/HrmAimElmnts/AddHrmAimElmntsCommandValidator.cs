using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddHrmAimElmntsCommandValidator : AbstractValidator<AddHrmAimElmntsCommand>
    {
        public AddHrmAimElmntsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
