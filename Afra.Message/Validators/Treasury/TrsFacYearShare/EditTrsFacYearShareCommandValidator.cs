using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditTrsFacYearShareCommandValidator : AbstractValidator<EditTrsFacYearShareCommand>
    {
        public EditTrsFacYearShareCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
