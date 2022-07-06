using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddGnrProcessDetArchCommandValidator : AbstractValidator<AddGnrProcessDetArchCommand>
    {
        public AddGnrProcessDetArchCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
