using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditHrmAimElmntsCommandValidator : AbstractValidator<EditHrmAimElmntsCommand>
    {
        public EditHrmAimElmntsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
