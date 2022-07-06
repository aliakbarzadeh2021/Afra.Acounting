using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddPayCalcCtrlCommandValidator : AbstractValidator<AddPayCalcCtrlCommand>
    {
        public AddPayCalcCtrlCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
