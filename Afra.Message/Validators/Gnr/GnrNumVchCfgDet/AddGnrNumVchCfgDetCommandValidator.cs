using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddGnrNumVchCfgDetCommandValidator : AbstractValidator<AddGnrNumVchCfgDetCommand>
    {
        public AddGnrNumVchCfgDetCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
