using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditUsrvchBaseInfoCommandValidator : AbstractValidator<EditUsrvchBaseInfoCommand>
    {
        public EditUsrvchBaseInfoCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
