using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddInvPartCtgryCommandValidator : AbstractValidator<AddInvPartCtgryCommand>
    {
        public AddInvPartCtgryCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
