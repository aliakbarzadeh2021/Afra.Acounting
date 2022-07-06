using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddCmrInvoiceItmCommandValidator : AbstractValidator<AddCmrInvoiceItmCommand>
    {
        public AddCmrInvoiceItmCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
