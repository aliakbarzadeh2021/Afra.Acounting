using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditGnrFormSettingCommandValidator : AbstractValidator<EditGnrFormSettingCommand>
    {
        public EditGnrFormSettingCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
