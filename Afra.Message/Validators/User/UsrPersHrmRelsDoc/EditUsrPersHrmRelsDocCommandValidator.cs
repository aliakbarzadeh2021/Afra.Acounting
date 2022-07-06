using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditUsrPersHrmRelsDocCommandValidator : AbstractValidator<EditUsrPersHrmRelsDocCommand>
    {
        public EditUsrPersHrmRelsDocCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
