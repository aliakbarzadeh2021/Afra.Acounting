using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditCmrInvoiceCostCommandValidator : AbstractValidator<EditCmrInvoiceCostCommand>
    {
        public EditCmrInvoiceCostCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
