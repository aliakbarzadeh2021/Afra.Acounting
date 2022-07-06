using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditCmrInvoiceHdrCommandValidator : AbstractValidator<EditCmrInvoiceHdrCommand>
    {
        public EditCmrInvoiceHdrCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
