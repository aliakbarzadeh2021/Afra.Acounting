using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddTrsFacilitiesGuaCommandValidator : AbstractValidator<AddTrsFacilitiesGuaCommand>
    {
        public AddTrsFacilitiesGuaCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
