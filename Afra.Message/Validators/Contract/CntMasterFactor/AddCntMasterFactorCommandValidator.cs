using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddCntMasterFactorCommandValidator : AbstractValidator<AddCntMasterFactorCommand>
    {
        public AddCntMasterFactorCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
