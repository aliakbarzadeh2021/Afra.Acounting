using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditUsrPersHrmRelsConsCommandValidator : AbstractValidator<EditUsrPersHrmRelsConsCommand>
    {
        public EditUsrPersHrmRelsConsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
