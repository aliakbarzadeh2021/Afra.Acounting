using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditUsGroupAccessCommandValidator : AbstractValidator<EditUsGroupAccessCommand>
    {
        public EditUsGroupAccessCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
