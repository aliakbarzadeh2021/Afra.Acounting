using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddPayCalcCtrlDetCommandValidator : AbstractValidator<AddPayCalcCtrlDetCommand>
    {
        public AddPayCalcCtrlDetCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
