using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditCntGnrTextCommandValidator : AbstractValidator<EditCntGnrTextCommand>
    {
        public EditCntGnrTextCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
