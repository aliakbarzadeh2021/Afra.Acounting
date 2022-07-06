using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditPayCalcBaseCommandValidator : AbstractValidator<EditPayCalcBaseCommand>
    {
        public EditPayCalcBaseCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
