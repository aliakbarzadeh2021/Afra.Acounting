using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditInvVchDefAccCommandValidator : AbstractValidator<EditInvVchDefAccCommand>
    {
        public EditInvVchDefAccCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
