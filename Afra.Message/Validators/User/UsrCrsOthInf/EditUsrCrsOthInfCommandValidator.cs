using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditUsrCrsOthInfCommandValidator : AbstractValidator<EditUsrCrsOthInfCommand>
    {
        public EditUsrCrsOthInfCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
