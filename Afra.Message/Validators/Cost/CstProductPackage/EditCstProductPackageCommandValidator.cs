using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditCstProductPackageCommandValidator : AbstractValidator<EditCstProductPackageCommand>
    {
        public EditCstProductPackageCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
