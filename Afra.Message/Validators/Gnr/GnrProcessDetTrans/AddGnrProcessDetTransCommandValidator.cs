using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddGnrProcessDetTransCommandValidator : AbstractValidator<AddGnrProcessDetTransCommand>
    {
        public AddGnrProcessDetTransCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
