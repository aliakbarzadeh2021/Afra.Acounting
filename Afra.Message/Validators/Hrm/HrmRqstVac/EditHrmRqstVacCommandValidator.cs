using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditHrmRqstVacCommandValidator : AbstractValidator<EditHrmRqstVacCommand>
    {
        public EditHrmRqstVacCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
