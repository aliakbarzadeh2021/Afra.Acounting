using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditAccVchKindDescrCommandValidator : AbstractValidator<EditAccVchKindDescrCommand>
    {
        public EditAccVchKindDescrCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
