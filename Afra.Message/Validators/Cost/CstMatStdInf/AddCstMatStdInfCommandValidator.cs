using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddCstMatStdInfCommandValidator : AbstractValidator<AddCstMatStdInfCommand>
    {
        public AddCstMatStdInfCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
