using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditUsrNewsCheckRqstCommandValidator : AbstractValidator<EditUsrNewsCheckRqstCommand>
    {
        public EditUsrNewsCheckRqstCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
