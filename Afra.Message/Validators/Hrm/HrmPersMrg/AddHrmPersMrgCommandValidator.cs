using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddHrmPersMrgCommandValidator : AbstractValidator<AddHrmPersMrgCommand>
    {
        public AddHrmPersMrgCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
