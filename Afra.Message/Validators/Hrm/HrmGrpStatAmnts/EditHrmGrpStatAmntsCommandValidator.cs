using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditHrmGrpStatAmntsCommandValidator : AbstractValidator<EditHrmGrpStatAmntsCommand>
    {
        public EditHrmGrpStatAmntsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
