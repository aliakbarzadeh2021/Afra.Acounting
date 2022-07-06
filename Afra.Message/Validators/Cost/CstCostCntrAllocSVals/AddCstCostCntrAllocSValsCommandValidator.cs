using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddCstCostCntrAllocSValsCommandValidator : AbstractValidator<AddCstCostCntrAllocSValsCommand>
    {
        public AddCstCostCntrAllocSValsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
