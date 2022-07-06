using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddUserProcessStpCommandValidator : AbstractValidator<AddUserProcessStpCommand>
    {
        public AddUserProcessStpCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
