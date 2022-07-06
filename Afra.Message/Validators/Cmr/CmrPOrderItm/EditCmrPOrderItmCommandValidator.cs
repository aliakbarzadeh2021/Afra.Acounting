using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditCmrPOrderItmCommandValidator : AbstractValidator<EditCmrPOrderItmCommand>
    {
        public EditCmrPOrderItmCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
