using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditTrsFacilitiesSecCommandValidator : AbstractValidator<EditTrsFacilitiesSecCommand>
    {
        public EditTrsFacilitiesSecCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
