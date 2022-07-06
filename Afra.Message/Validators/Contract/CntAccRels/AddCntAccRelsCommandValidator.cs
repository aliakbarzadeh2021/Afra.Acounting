using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddCntAccRelsCommandValidator : AbstractValidator<AddCntAccRelsCommand>
    {
        public AddCntAccRelsCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
