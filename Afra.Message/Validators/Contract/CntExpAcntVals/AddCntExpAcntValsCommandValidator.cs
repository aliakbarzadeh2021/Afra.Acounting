using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddCntExpAcntValsCommandValidator : AbstractValidator<AddCntExpAcntValsCommand>
    {
        public AddCntExpAcntValsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
