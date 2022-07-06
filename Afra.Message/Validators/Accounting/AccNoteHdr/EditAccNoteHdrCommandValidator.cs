using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditAccNoteHdrCommandValidator : AbstractValidator<EditAccNoteHdrCommand>
    {
        public EditAccNoteHdrCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
