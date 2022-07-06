using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddOtoTransScriptCommandValidator : AbstractValidator<AddOtoTransScriptCommand>
    {
        public AddOtoTransScriptCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
