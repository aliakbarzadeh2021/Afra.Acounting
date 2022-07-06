using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddHrmGrpStatPersCommandValidator : AbstractValidator<AddHrmGrpStatPersCommand>
    {
        public AddHrmGrpStatPersCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
