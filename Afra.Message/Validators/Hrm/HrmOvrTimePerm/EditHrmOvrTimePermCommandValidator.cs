using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditHrmOvrTimePermCommandValidator : AbstractValidator<EditHrmOvrTimePermCommand>
    {
        public EditHrmOvrTimePermCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
