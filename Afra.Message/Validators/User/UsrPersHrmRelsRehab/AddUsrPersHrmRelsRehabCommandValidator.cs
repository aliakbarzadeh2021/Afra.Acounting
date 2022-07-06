using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddUsrPersHrmRelsRehabCommandValidator : AbstractValidator<AddUsrPersHrmRelsRehabCommand>
    {
        public AddUsrPersHrmRelsRehabCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
