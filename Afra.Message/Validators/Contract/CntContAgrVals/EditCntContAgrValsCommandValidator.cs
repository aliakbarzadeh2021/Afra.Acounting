using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditCntContAgrValsCommandValidator : AbstractValidator<EditCntContAgrValsCommand>
    {
        public EditCntContAgrValsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
