using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditTrsFundItmDetCommandValidator : AbstractValidator<EditTrsFundItmDetCommand>
    {
        public EditTrsFundItmDetCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
