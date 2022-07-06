using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditTrsFacilitiesDetCommandValidator : AbstractValidator<EditTrsFacilitiesDetCommand>
    {
        public EditTrsFacilitiesDetCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
