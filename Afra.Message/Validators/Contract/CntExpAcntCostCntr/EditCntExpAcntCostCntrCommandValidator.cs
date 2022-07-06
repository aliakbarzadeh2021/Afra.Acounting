using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditCntExpAcntCostCntrCommandValidator : AbstractValidator<EditCntExpAcntCostCntrCommand>
    {
        public EditCntExpAcntCostCntrCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
