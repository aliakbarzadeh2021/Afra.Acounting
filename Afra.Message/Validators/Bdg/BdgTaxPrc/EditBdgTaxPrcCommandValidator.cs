using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditBdgTaxPrcCommandValidator : AbstractValidator<EditBdgTaxPrcCommand>
    {
        public EditBdgTaxPrcCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
