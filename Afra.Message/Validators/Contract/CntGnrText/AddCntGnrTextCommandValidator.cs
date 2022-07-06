using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddCntGnrTextCommandValidator : AbstractValidator<AddCntGnrTextCommand>
    {
        public AddCntGnrTextCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
