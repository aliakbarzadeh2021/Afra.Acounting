using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddTrsFundItmDetCommandValidator : AbstractValidator<AddTrsFundItmDetCommand>
    {
        public AddTrsFundItmDetCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
