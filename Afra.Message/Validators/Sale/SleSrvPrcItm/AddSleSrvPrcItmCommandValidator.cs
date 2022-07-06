using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddSleSrvPrcItmCommandValidator : AbstractValidator<AddSleSrvPrcItmCommand>
    {
        public AddSleSrvPrcItmCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
