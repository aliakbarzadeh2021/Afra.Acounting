using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddCstProductPackageCommandValidator : AbstractValidator<AddCstProductPackageCommand>
    {
        public AddCstProductPackageCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
