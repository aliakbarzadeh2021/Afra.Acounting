using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditTrsPayBoredItmCommandValidator : AbstractValidator<EditTrsPayBoredItmCommand>
    {
        public EditTrsPayBoredItmCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
