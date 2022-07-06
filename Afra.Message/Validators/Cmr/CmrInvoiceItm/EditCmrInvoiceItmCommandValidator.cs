using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditCmrInvoiceItmCommandValidator : AbstractValidator<EditCmrInvoiceItmCommand>
    {
        public EditCmrInvoiceItmCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
