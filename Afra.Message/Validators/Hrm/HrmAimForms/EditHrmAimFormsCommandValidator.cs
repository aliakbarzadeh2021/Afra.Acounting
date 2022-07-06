using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditHrmAimFormsCommandValidator : AbstractValidator<EditHrmAimFormsCommand>
    {
        public EditHrmAimFormsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
