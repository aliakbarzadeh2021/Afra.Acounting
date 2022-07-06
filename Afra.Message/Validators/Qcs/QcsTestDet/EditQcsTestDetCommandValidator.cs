using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditQcsTestDetCommandValidator : AbstractValidator<EditQcsTestDetCommand>
    {
        public EditQcsTestDetCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
