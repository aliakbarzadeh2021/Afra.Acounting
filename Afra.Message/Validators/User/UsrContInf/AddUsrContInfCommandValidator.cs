using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddUsrContInfCommandValidator : AbstractValidator<AddUsrContInfCommand>
    {
        public AddUsrContInfCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
