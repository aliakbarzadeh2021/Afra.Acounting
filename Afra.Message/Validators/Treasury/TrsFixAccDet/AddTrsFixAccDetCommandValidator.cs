using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddTrsFixAccDetCommandValidator : AbstractValidator<AddTrsFixAccDetCommand>
    {
        public AddTrsFixAccDetCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
