using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditCmrPreFactHdrCommandValidator : AbstractValidator<EditCmrPreFactHdrCommand>
    {
        public EditCmrPreFactHdrCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
