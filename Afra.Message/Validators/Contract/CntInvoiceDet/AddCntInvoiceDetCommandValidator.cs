using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddCntInvoiceDetCommandValidator : AbstractValidator<AddCntInvoiceDetCommand>
    {
        public AddCntInvoiceDetCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
