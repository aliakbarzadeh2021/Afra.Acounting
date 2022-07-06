using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddCmrPOrderItmCommandValidator : AbstractValidator<AddCmrPOrderItmCommand>
    {
        public AddCmrPOrderItmCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
