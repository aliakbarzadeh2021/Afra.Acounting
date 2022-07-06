using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditGnrLimitGroupCommandValidator : AbstractValidator<EditGnrLimitGroupCommand>
    {
        public EditGnrLimitGroupCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
