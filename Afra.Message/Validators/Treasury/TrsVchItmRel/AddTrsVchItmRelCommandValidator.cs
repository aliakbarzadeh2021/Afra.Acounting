using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddTrsVchItmRelCommandValidator : AbstractValidator<AddTrsVchItmRelCommand>
    {
        public AddTrsVchItmRelCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
