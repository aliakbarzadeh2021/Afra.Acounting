using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddTrsFacilitiesCommandValidator : AbstractValidator<AddTrsFacilitiesCommand>
    {
        public AddTrsFacilitiesCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
