using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddHrmPersRltdCommandValidator : AbstractValidator<AddHrmPersRltdCommand>
    {
        public AddHrmPersRltdCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
