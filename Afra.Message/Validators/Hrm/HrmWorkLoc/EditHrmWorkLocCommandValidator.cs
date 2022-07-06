using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditHrmWorkLocCommandValidator : AbstractValidator<EditHrmWorkLocCommand>
    {
        public EditHrmWorkLocCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
