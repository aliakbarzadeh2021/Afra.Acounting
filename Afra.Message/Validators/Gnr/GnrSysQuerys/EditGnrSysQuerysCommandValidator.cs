using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditGnrSysQuerysCommandValidator : AbstractValidator<EditGnrSysQuerysCommand>
    {
        public EditGnrSysQuerysCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
