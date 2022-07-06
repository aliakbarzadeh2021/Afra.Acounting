using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddHrmGrpStatAmntsCommandValidator : AbstractValidator<AddHrmGrpStatAmntsCommand>
    {
        public AddHrmGrpStatAmntsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
