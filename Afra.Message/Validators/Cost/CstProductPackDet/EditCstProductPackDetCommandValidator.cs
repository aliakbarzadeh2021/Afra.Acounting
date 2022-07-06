using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditCstProductPackDetCommandValidator : AbstractValidator<EditCstProductPackDetCommand>
    {
        public EditCstProductPackDetCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
