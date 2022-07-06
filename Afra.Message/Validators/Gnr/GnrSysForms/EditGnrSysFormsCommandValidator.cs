using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditGnrSysFormsCommandValidator : AbstractValidator<EditGnrSysFormsCommand>
    {
        public EditGnrSysFormsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
