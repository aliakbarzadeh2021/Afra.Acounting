using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditUserPlaningDetCommandValidator : AbstractValidator<EditUserPlaningDetCommand>
    {
        public EditUserPlaningDetCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
