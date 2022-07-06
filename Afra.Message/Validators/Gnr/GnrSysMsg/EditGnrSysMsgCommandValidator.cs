using FluentValidation;
using Afra.Message.Commands;
using Afra.Message.Extentions;
using System;

namespace Afra.Message.Validators
{
    public class EditGnrSysMsgCommandValidator : AbstractValidator<EditGnrSysMsgCommand>
    {
        public EditGnrSysMsgCommandValidator()
        {
            //RuleFor(x => x.Id).NotEmpty("عنوان");
        }
    }
}
