using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddCstStdAccDataCommandValidator : AbstractValidator<AddCstStdAccDataCommand>
    {
        public AddCstStdAccDataCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
