using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddTrsAccOprCommandValidator : AbstractValidator<AddTrsAccOprCommand>
    {
        public AddTrsAccOprCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
