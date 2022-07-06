using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditCntInvoiceDetCommandValidator : AbstractValidator<EditCntInvoiceDetCommand>
    {
        public EditCntInvoiceDetCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
