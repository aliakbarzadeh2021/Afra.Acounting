using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditBdgTaxPrcCostCommandValidator : AbstractValidator<EditBdgTaxPrcCostCommand>
    {
        public EditBdgTaxPrcCostCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
