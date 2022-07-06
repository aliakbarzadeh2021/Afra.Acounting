using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddOtoLttrLinksCommandValidator : AbstractValidator<AddOtoLttrLinksCommand>
    {
        public AddOtoLttrLinksCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
