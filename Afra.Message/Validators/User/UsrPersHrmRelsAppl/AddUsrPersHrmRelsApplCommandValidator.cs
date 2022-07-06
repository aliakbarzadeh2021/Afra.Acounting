using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddUsrPersHrmRelsApplCommandValidator : AbstractValidator<AddUsrPersHrmRelsApplCommand>
    {
        public AddUsrPersHrmRelsApplCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
