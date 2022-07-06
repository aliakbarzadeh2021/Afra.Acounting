using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditOtoTransScriptCommandValidator : AbstractValidator<EditOtoTransScriptCommand>
    {
        public EditOtoTransScriptCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
