using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditHrmPersCompAsignCommandValidator : AbstractValidator<EditHrmPersCompAsignCommand>
    {
        public EditHrmPersCompAsignCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
