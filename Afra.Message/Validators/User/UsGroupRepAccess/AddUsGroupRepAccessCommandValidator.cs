using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddUsGroupRepAccessCommandValidator : AbstractValidator<AddUsGroupRepAccessCommand>
    {
        public AddUsGroupRepAccessCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
