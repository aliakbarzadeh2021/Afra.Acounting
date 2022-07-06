using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditUserRepAccessCommandValidator : AbstractValidator<EditUserRepAccessCommand>
    {
        public EditUserRepAccessCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
