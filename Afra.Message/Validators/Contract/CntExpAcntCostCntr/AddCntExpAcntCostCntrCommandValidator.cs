using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddCntExpAcntCostCntrCommandValidator : AbstractValidator<AddCntExpAcntCostCntrCommand>
    {
        public AddCntExpAcntCostCntrCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
