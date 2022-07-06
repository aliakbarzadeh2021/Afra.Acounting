using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddAstDeprVchCommandValidator : AbstractValidator<AddAstDeprVchCommand>
    {
        public AddAstDeprVchCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
