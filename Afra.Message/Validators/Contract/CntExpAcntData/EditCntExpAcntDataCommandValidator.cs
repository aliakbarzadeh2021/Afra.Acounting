using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditCntExpAcntDataCommandValidator : AbstractValidator<EditCntExpAcntDataCommand>
    {
        public EditCntExpAcntDataCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
