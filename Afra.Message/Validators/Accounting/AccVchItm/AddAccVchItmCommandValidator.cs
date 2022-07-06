using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddAccVchItmCommandValidator : AbstractValidator<AddAccVchItmCommand>
    {
        public AddAccVchItmCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
