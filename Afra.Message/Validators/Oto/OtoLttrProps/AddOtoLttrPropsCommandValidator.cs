using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddOtoLttrPropsCommandValidator : AbstractValidator<AddOtoLttrPropsCommand>
    {
        public AddOtoLttrPropsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
