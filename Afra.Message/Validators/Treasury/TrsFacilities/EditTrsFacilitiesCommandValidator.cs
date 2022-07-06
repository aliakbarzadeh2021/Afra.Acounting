using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditTrsFacilitiesCommandValidator : AbstractValidator<EditTrsFacilitiesCommand>
    {
        public EditTrsFacilitiesCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
