using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddHrmPersAccountCommandValidator : AbstractValidator<AddHrmPersAccountCommand>
    {
        public AddHrmPersAccountCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
