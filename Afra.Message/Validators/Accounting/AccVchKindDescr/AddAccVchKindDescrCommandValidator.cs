using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddAccVchKindDescrCommandValidator : AbstractValidator<AddAccVchKindDescrCommand>
    {
        public AddAccVchKindDescrCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
