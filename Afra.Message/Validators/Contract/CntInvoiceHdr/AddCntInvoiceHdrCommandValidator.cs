using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddCntInvoiceHdrCommandValidator : AbstractValidator<AddCntInvoiceHdrCommand>
    {
        public AddCntInvoiceHdrCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
