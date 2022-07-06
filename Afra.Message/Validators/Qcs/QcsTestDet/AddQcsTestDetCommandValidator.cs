using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddQcsTestDetCommandValidator : AbstractValidator<AddQcsTestDetCommand>
    {
        public AddQcsTestDetCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
