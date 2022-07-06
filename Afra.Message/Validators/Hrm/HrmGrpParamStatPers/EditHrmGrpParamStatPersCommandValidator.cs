using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditHrmGrpParamStatPersCommandValidator : AbstractValidator<EditHrmGrpParamStatPersCommand>
    {
        public EditHrmGrpParamStatPersCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
