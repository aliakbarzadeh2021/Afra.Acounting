using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditUserPlaningDetInfCommandValidator : AbstractValidator<EditUserPlaningDetInfCommand>
    {
        public EditUserPlaningDetInfCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
