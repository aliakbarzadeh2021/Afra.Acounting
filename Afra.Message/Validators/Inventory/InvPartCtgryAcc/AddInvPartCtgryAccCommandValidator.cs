using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddInvPartCtgryAccCommandValidator : AbstractValidator<AddInvPartCtgryAccCommand>
    {
        public AddInvPartCtgryAccCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
