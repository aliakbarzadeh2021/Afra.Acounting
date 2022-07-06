using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditSleAftSrvCommandValidator : AbstractValidator<EditSleAftSrvCommand>
    {
        public EditSleAftSrvCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
