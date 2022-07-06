using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddInvVchDefAccCommandValidator : AbstractValidator<AddInvVchDefAccCommand>
    {
        public AddInvVchDefAccCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
