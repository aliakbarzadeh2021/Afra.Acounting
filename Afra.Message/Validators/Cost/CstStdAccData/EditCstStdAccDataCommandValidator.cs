using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditCstStdAccDataCommandValidator : AbstractValidator<EditCstStdAccDataCommand>
    {
        public EditCstStdAccDataCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
