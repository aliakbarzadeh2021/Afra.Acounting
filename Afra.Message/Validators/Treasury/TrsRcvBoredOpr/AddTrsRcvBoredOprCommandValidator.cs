using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddTrsRcvBoredOprCommandValidator : AbstractValidator<AddTrsRcvBoredOprCommand>
    {
        public AddTrsRcvBoredOprCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
