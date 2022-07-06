using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditTrsBankChqsDetCommandValidator : AbstractValidator<EditTrsBankChqsDetCommand>
    {
        public EditTrsBankChqsDetCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
