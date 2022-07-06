using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddTrsVchItmBaseCommandValidator : AbstractValidator<AddTrsVchItmBaseCommand>
    {
        public AddTrsVchItmBaseCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
