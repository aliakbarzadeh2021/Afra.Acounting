using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddCntMasterFactValCommandValidator : AbstractValidator<AddCntMasterFactValCommand>
    {
        public AddCntMasterFactValCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
