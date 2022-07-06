using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditHrmPersRltdCommandValidator : AbstractValidator<EditHrmPersRltdCommand>
    {
        public EditHrmPersRltdCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
