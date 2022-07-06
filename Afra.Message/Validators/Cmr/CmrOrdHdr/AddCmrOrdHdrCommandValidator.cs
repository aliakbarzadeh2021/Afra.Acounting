using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddCmrOrdHdrCommandValidator : AbstractValidator<AddCmrOrdHdrCommand>
    {
        public AddCmrOrdHdrCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
