using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddUserPlaningDetInfCommandValidator : AbstractValidator<AddUserPlaningDetInfCommand>
    {
        public AddUserPlaningDetInfCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
