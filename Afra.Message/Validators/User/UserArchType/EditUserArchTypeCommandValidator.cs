using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditUserArchTypeCommandValidator : AbstractValidator<EditUserArchTypeCommand>
    {
        public EditUserArchTypeCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
