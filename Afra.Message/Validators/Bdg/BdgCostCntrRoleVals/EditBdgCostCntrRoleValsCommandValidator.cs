using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditBdgCostCntrRoleValsCommandValidator : AbstractValidator<EditBdgCostCntrRoleValsCommand>
    {
        public EditBdgCostCntrRoleValsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
