using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddUsrPersHrmRelsCommandValidator : AbstractValidator<AddUsrPersHrmRelsCommand>
    {
        public AddUsrPersHrmRelsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
