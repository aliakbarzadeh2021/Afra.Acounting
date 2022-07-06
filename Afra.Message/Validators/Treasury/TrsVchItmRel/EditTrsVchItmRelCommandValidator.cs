using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditTrsVchItmRelCommandValidator : AbstractValidator<EditTrsVchItmRelCommand>
    {
        public EditTrsVchItmRelCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
