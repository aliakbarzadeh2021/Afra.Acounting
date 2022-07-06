using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddAccSLStdDescCommandValidator : AbstractValidator<AddAccSLStdDescCommand>
    {
        public AddAccSLStdDescCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
