using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditOtoTemplatesCommandValidator : AbstractValidator<EditOtoTemplatesCommand>
    {
        public EditOtoTemplatesCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
