using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditCntContAmntChngCommandValidator : AbstractValidator<EditCntContAmntChngCommand>
    {
        public EditCntContAmntChngCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
