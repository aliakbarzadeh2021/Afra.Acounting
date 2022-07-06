using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditCmrReleaseHdrCommandValidator : AbstractValidator<EditCmrReleaseHdrCommand>
    {
        public EditCmrReleaseHdrCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
