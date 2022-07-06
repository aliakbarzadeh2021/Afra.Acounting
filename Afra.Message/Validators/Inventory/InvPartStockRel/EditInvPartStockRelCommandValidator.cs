using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditInvPartStockRelCommandValidator : AbstractValidator<EditInvPartStockRelCommand>
    {
        public EditInvPartStockRelCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
