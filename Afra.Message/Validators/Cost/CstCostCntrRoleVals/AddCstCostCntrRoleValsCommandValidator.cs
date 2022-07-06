using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddCstCostCntrRoleValsCommandValidator : AbstractValidator<AddCstCostCntrRoleValsCommand>
    {
        public AddCstCostCntrRoleValsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
