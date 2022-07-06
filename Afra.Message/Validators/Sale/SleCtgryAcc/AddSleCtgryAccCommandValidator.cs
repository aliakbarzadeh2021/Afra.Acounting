using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddSleCtgryAccCommandValidator : AbstractValidator<AddSleCtgryAccCommand>
    {
        public AddSleCtgryAccCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
