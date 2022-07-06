using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddGnrSysQuerysCommandValidator : AbstractValidator<AddGnrSysQuerysCommand>
    {
        public AddGnrSysQuerysCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
