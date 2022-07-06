using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddCntExpAcntDetCommandValidator : AbstractValidator<AddCntExpAcntDetCommand>
    {
        public AddCntExpAcntDetCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
