using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddUsrNewsCheckRqstCommandValidator : AbstractValidator<AddUsrNewsCheckRqstCommand>
    {
        public AddUsrNewsCheckRqstCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
