using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditPayCalcCtrlDetCommandValidator : AbstractValidator<EditPayCalcCtrlDetCommand>
    {
        public EditPayCalcCtrlDetCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
