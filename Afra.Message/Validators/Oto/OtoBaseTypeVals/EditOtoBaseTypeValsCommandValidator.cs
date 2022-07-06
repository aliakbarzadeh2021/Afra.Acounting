using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditOtoBaseTypeValsCommandValidator : AbstractValidator<EditOtoBaseTypeValsCommand>
    {
        public EditOtoBaseTypeValsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
