using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditCmrTransportDetCommandValidator : AbstractValidator<EditCmrTransportDetCommand>
    {
        public EditCmrTransportDetCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
