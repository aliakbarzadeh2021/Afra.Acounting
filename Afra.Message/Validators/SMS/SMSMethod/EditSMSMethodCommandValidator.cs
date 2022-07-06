using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditSMSMethodCommandValidator : AbstractValidator<EditSMSMethodCommand>
    {
        public EditSMSMethodCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
