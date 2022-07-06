using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddOtoQuickNoteCommandValidator : AbstractValidator<AddOtoQuickNoteCommand>
    {
        public AddOtoQuickNoteCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
