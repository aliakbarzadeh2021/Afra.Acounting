using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddCmrInvoiceHdrCommandValidator : AbstractValidator<AddCmrInvoiceHdrCommand>
    {
        public AddCmrInvoiceHdrCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
