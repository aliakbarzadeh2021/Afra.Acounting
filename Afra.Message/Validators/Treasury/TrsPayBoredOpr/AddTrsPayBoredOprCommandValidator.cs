using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddTrsPayBoredOprCommandValidator : AbstractValidator<AddTrsPayBoredOprCommand>
    {
        public AddTrsPayBoredOprCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
