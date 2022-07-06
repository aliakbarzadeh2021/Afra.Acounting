using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddCstCostCntrElmntValsCommandValidator : AbstractValidator<AddCstCostCntrElmntValsCommand>
    {
        public AddCstCostCntrElmntValsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
