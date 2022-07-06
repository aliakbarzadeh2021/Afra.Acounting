using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddTrsRcvChqOprCommandValidator : AbstractValidator<AddTrsRcvChqOprCommand>
    {
        public AddTrsRcvChqOprCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
