using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddHrmGrpParamStatCommandValidator : AbstractValidator<AddHrmGrpParamStatCommand>
    {
        public AddHrmGrpParamStatCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
