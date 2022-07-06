using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddUserPlaningDetCommandValidator : AbstractValidator<AddUserPlaningDetCommand>
    {
        public AddUserPlaningDetCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
