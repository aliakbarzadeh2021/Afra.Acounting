using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddBdgCostCntrRoleValsCommandValidator : AbstractValidator<AddBdgCostCntrRoleValsCommand>
    {
        public AddBdgCostCntrRoleValsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
