using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditInvPartCtgryAccCommandValidator : AbstractValidator<EditInvPartCtgryAccCommand>
    {
        public EditInvPartCtgryAccCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
