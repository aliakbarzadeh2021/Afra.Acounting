using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditTrsPayBoredOprCommandValidator : AbstractValidator<EditTrsPayBoredOprCommand>
    {
        public EditTrsPayBoredOprCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
