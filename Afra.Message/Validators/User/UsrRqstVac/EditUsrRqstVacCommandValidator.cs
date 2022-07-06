using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditUsrRqstVacCommandValidator : AbstractValidator<EditUsrRqstVacCommand>
    {
        public EditUsrRqstVacCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
