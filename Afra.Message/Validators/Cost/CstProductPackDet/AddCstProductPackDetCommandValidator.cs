using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddCstProductPackDetCommandValidator : AbstractValidator<AddCstProductPackDetCommand>
    {
        public AddCstProductPackDetCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
