using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditAccCloseHdrCommandValidator : AbstractValidator<EditAccCloseHdrCommand>
    {
        public EditAccCloseHdrCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
