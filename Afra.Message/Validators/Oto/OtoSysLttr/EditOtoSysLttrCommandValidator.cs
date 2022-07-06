using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditOtoSysLttrCommandValidator : AbstractValidator<EditOtoSysLttrCommand>
    {
        public EditOtoSysLttrCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
