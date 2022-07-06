using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditPayUserFieldCommandValidator : AbstractValidator<EditPayUserFieldCommand>
    {
        public EditPayUserFieldCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
