using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddCmrPreFactItmCommandValidator : AbstractValidator<AddCmrPreFactItmCommand>
    {
        public AddCmrPreFactItmCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
