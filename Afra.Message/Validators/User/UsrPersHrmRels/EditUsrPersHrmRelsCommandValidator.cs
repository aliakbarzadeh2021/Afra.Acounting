using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditUsrPersHrmRelsCommandValidator : AbstractValidator<EditUsrPersHrmRelsCommand>
    {
        public EditUsrPersHrmRelsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
