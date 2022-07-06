using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddUsrCrsOthInfCommandValidator : AbstractValidator<AddUsrCrsOthInfCommand>
    {
        public AddUsrCrsOthInfCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
