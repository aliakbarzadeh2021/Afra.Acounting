using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditHrmPersEduCommandValidator : AbstractValidator<EditHrmPersEduCommand>
    {
        public EditHrmPersEduCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
