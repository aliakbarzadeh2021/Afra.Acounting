using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddQcsVchItmCommandValidator : AbstractValidator<AddQcsVchItmCommand>
    {
        public AddQcsVchItmCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
