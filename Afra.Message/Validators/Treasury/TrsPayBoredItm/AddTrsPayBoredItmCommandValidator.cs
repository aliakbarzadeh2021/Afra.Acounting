using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddTrsPayBoredItmCommandValidator : AbstractValidator<AddTrsPayBoredItmCommand>
    {
        public AddTrsPayBoredItmCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
