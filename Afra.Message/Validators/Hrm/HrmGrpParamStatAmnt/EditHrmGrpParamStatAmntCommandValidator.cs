using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditHrmGrpParamStatAmntCommandValidator : AbstractValidator<EditHrmGrpParamStatAmntCommand>
    {
        public EditHrmGrpParamStatAmntCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
