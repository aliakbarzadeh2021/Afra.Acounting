using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddPayValStatAmntCommandValidator : AbstractValidator<AddPayValStatAmntCommand>
    {
        public AddPayValStatAmntCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
