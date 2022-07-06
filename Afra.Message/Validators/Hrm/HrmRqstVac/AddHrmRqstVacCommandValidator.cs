using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddHrmRqstVacCommandValidator : AbstractValidator<AddHrmRqstVacCommand>
    {
        public AddHrmRqstVacCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
