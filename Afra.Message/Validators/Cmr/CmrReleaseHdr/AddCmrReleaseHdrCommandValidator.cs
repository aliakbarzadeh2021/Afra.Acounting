using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddCmrReleaseHdrCommandValidator : AbstractValidator<AddCmrReleaseHdrCommand>
    {
        public AddCmrReleaseHdrCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
