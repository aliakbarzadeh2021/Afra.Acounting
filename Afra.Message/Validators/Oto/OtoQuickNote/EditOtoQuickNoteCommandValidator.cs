using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditOtoQuickNoteCommandValidator : AbstractValidator<EditOtoQuickNoteCommand>
    {
        public EditOtoQuickNoteCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
