using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddCmrPOrderHdrCommandValidator : AbstractValidator<AddCmrPOrderHdrCommand>
    {
        public AddCmrPOrderHdrCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
