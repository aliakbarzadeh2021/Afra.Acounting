using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddHrmIncDecVacCommandValidator : AbstractValidator<AddHrmIncDecVacCommand>
    {
        public AddHrmIncDecVacCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
