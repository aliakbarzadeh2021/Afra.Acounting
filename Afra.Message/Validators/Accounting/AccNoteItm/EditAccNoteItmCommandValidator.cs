using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditAccNoteItmCommandValidator : AbstractValidator<EditAccNoteItmCommand>
    {
        public EditAccNoteItmCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
