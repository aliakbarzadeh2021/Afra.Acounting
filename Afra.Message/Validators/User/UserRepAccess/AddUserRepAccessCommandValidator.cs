using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddUserRepAccessCommandValidator : AbstractValidator<AddUserRepAccessCommand>
    {
        public AddUserRepAccessCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
