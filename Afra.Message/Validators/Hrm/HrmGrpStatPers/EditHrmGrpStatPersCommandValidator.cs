using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditHrmGrpStatPersCommandValidator : AbstractValidator<EditHrmGrpStatPersCommand>
    {
        public EditHrmGrpStatPersCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
