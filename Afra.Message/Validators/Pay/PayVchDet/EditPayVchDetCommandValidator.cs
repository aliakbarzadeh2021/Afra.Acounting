using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditPayVchDetCommandValidator : AbstractValidator<EditPayVchDetCommand>
    {
        public EditPayVchDetCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
