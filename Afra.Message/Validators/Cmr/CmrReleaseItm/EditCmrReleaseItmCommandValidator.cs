using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditCmrReleaseItmCommandValidator : AbstractValidator<EditCmrReleaseItmCommand>
    {
        public EditCmrReleaseItmCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
