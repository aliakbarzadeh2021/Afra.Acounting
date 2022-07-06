using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddOtoLttrDocCommandValidator : AbstractValidator<AddOtoLttrDocCommand>
    {
        public AddOtoLttrDocCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
