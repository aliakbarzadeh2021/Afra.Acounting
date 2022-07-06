using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditCntExpAccntRelsCommandValidator : AbstractValidator<EditCntExpAccntRelsCommand>
    {
        public EditCntExpAccntRelsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
