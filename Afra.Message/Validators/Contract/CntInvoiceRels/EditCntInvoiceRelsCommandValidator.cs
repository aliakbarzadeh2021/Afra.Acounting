using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditCntInvoiceRelsCommandValidator : AbstractValidator<EditCntInvoiceRelsCommand>
    {
        public EditCntInvoiceRelsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
