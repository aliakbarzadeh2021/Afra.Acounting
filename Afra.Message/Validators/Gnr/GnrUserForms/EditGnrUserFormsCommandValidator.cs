using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditGnrUserFormsCommandValidator : AbstractValidator<EditGnrUserFormsCommand>
    {
        public EditGnrUserFormsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
