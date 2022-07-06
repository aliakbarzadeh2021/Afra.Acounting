using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditCmrOrdHdrCommandValidator : AbstractValidator<EditCmrOrdHdrCommand>
    {
        public EditCmrOrdHdrCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
