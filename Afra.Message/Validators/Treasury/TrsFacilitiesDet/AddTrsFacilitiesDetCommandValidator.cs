using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddTrsFacilitiesDetCommandValidator : AbstractValidator<AddTrsFacilitiesDetCommand>
    {
        public AddTrsFacilitiesDetCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
