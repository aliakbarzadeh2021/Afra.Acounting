using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditTrsVchItmBaseCommandValidator : AbstractValidator<EditTrsVchItmBaseCommand>
    {
        public EditTrsVchItmBaseCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
