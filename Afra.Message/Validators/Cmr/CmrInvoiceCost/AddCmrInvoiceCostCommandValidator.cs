using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddCmrInvoiceCostCommandValidator : AbstractValidator<AddCmrInvoiceCostCommand>
    {
        public AddCmrInvoiceCostCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
