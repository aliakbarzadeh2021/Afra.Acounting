using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddBdgContAccDetCommandValidator : AbstractValidator<AddBdgContAccDetCommand>
    {
        public AddBdgContAccDetCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
