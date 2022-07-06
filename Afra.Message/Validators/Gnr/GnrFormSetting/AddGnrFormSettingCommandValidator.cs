using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddGnrFormSettingCommandValidator : AbstractValidator<AddGnrFormSettingCommand>
    {
        public AddGnrFormSettingCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
