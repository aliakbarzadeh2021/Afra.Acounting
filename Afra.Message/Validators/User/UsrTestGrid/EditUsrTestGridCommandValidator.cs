using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditUsrTestGridCommandValidator : AbstractValidator<EditUsrTestGridCommand>
    {
        public EditUsrTestGridCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
