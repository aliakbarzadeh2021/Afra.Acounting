using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditGnrNumVchConfigCommandValidator : AbstractValidator<EditGnrNumVchConfigCommand>
    {
        public EditGnrNumVchConfigCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
