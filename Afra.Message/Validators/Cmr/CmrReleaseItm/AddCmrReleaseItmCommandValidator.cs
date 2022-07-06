using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddCmrReleaseItmCommandValidator : AbstractValidator<AddCmrReleaseItmCommand>
    {
        public AddCmrReleaseItmCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
