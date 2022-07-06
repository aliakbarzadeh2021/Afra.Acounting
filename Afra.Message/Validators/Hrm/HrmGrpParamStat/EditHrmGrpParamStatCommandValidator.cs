using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditHrmGrpParamStatCommandValidator : AbstractValidator<EditHrmGrpParamStatCommand>
    {
        public EditHrmGrpParamStatCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
