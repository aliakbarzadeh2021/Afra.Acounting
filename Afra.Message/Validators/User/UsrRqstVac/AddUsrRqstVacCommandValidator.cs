using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddUsrRqstVacCommandValidator : AbstractValidator<AddUsrRqstVacCommand>
    {
        public AddUsrRqstVacCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
