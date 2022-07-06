using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditOtoLttrDocCommandValidator : AbstractValidator<EditOtoLttrDocCommand>
    {
        public EditOtoLttrDocCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
