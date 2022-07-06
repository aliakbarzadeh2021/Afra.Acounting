using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddGnrNumVchConfigCommandValidator : AbstractValidator<AddGnrNumVchConfigCommand>
    {
        public AddGnrNumVchConfigCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
