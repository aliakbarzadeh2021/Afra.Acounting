using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddCntExpnsAccntsCommandValidator : AbstractValidator<AddCntExpnsAccntsCommand>
    {
        public AddCntExpnsAccntsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
