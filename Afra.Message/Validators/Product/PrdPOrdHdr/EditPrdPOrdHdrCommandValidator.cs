using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditPrdPOrdHdrCommandValidator : AbstractValidator<EditPrdPOrdHdrCommand>
    {
        public EditPrdPOrdHdrCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
