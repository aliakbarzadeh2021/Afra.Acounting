using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddHrmGrpParamStatAmntCommandValidator : AbstractValidator<AddHrmGrpParamStatAmntCommand>
    {
        public AddHrmGrpParamStatAmntCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
