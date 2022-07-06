using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddCntExpAccntRelsCommandValidator : AbstractValidator<AddCntExpAccntRelsCommand>
    {
        public AddCntExpAccntRelsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
