using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddCntContAgrValsCommandValidator : AbstractValidator<AddCntContAgrValsCommand>
    {
        public AddCntContAgrValsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
