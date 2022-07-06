using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddSleDebCreHdrCommandValidator : AbstractValidator<AddSleDebCreHdrCommand>
    {
        public AddSleDebCreHdrCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
