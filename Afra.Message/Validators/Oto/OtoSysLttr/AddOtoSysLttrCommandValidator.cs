using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddOtoSysLttrCommandValidator : AbstractValidator<AddOtoSysLttrCommand>
    {
        public AddOtoSysLttrCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
