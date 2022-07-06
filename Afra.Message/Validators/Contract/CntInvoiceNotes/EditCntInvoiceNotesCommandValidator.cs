using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditCntInvoiceNotesCommandValidator : AbstractValidator<EditCntInvoiceNotesCommand>
    {
        public EditCntInvoiceNotesCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
