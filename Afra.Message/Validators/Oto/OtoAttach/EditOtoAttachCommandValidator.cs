using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditOtoAttachCommandValidator : AbstractValidator<EditOtoAttachCommand>
    {
        public EditOtoAttachCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
