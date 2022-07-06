using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddHrmPersonnelsCommandValidator : AbstractValidator<AddHrmPersonnelsCommand>
    {
        public AddHrmPersonnelsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
