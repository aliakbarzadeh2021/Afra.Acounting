using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditCmrPOrderHdrCommandValidator : AbstractValidator<EditCmrPOrderHdrCommand>
    {
        public EditCmrPOrderHdrCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
