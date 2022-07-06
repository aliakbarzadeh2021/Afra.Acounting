using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class AddHrmOvrTimePermCommandValidator : AbstractValidator<AddHrmOvrTimePermCommand>
    {
        public AddHrmOvrTimePermCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
