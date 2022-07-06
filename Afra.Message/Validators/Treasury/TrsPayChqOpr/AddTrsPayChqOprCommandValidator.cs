using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddTrsPayChqOprCommandValidator : AbstractValidator<AddTrsPayChqOprCommand>
    {
        public AddTrsPayChqOprCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
