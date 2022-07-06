using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddPayUserFieldCommandValidator : AbstractValidator<AddPayUserFieldCommand>
    {
        public AddPayUserFieldCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
