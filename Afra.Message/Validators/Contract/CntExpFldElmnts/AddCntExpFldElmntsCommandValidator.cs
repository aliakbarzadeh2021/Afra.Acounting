using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddCntExpFldElmntsCommandValidator : AbstractValidator<AddCntExpFldElmntsCommand>
    {
        public AddCntExpFldElmntsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
