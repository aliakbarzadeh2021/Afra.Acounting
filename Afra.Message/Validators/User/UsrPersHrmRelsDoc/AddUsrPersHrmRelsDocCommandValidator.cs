using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddUsrPersHrmRelsDocCommandValidator : AbstractValidator<AddUsrPersHrmRelsDocCommand>
    {
        public AddUsrPersHrmRelsDocCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
